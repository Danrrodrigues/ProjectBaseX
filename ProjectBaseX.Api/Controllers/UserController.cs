using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBaseX.Api.ViewsModels;
using ProjectBaseX.Domain.Entities;
using ProjectBaseX.Service.Services;
using ProjectBaseX.Service.Validators;
using System;

namespace ProjectBaseX.Api.Controllers
{
    /// <summary>
    /// Classe de usuário 
    /// </summary>
    [Authorize("Bearer")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private BaseService<User> service = new BaseService<User>();

        /// <summary>
        /// Adiciona usuário
        /// </summary>
        /// <param name="model.name"></param>
        /// <param email="model.email"></param>
        /// <returns>Retorna id</returns>
        [HttpPost]
        [AllowAnonymous] 
        public IActionResult Post(UserViewModel model)
        {
            try
            {
                //TODO:Pendente configuração de erros da view
                //if (!ModelState.IsValid) return BadRequest(ModelState.ConfigErros());

                var user = Mapper.Map<User>(model);

                service.Post<UserValidator>(user);

                return new ObjectResult(user.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User item)
        {
            try
            {
                service.Put<UserValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Exclui o usuário pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca todos os usuários
        /// </summary>
        /// <returns>Retorna objeto User</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca usúario pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return new ObjectResult(service.GetByGuid(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}