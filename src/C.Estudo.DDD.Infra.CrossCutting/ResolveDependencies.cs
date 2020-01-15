using C.Estudo.DDD.Application.AppServices.Interfaces;
using C.Estudo.DDD.Application.AppServices.Services;
using C.Estudo.DDD.Domain.Interfaces.Repositories;
using C.Estudo.DDD.Domain.Interfaces.Services;
using C.Estudo.DDD.Domain.Services;
using C.Estudo.DDD.Infra.Data.Context;
using C.Estudo.DDD.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.DDD.Infra.CrossCutting
{
    public static class ResolveDependencies
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //Configuration
            services.AddSingleton<IConfiguration>(configuration);

            // Application
            services.AddScoped<IUserAppService, UserAppService>();

            // Domain
            services.AddScoped<IUserService, UserService>();

            // Repository
            services.AddScoped<IUserRepository, UserRepository>();

            // Context
            services.AddDbContext<EstudoContext>();

            // UoW
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
