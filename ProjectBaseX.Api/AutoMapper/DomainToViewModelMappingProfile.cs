using AutoMapper;
using ProjectBaseX.Api.ViewsModels;
using ProjectBaseX.Domain.Entities;

namespace ProjectBaseX.Api.AutoMapper
{
    /// <summary>
    /// Domain To ViewModel
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// Contructor Domain To ViewModel
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();

        }
    }
}
