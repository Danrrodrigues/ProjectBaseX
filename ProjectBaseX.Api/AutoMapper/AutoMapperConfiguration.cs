using AutoMapper;

namespace ProjectBaseX.Api.AutoMapper
{

    /// <summary>
    /// Arquivo de configuraçao do AutoMapper
    /// </summary>
    public class AutoMapperConfiguration
    {
        /// <summary>
        ///  Register Mappings for AutoMapper
        /// </summary>
        /// <returns></returns>
        public static void Configure()
        {
            //TODO: Migre  static for DI
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    } 
}
