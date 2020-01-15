using AutoMapper;
using C.Estudo.DDD.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.DDD.Api.Configurations.AutoMapper
{
    public static class AutoMapperConfiguration
    {

        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
