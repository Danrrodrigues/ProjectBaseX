using AutoMapper;
using ProjectBaseX.Api.ViewsModels;
using ProjectBaseX.Domain.Entities;

namespace ProjectBaseX.Api.AutoMapper
{
    /// <summary>
    /// Contructor ViewModel To Domain
    /// </summary>
    public class ViewModelToDomainMappingProfile : Profile
    {
        /// <summary>
        /// Contructor ViewModel To Domain
        /// </summary>
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();

        }
    }
}
