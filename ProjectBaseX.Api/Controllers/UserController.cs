using Microsoft.AspNetCore.Mvc;
using ProjectBaseX.Domain.Entities;
using ProjectBaseX.Service.Services;
using ProjectBaseX.Service.Validators;
using System;

namespace ProjectBaseX.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private BaseService<User> service = new BaseService<User>();

        public IActionResult Post([FromBody] User item)
        {
            try
            {
                service.Post<UserValidator>(item);

                return new ObjectResult(item.Id);
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

        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
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