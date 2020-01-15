using C.Estudo.DDD.Infra.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace C.Estudo.DDD.Api.Configurations.Db
{
    public static class SqlServerConfiguration
    {
        public static void AddSqlContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EstudoContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
