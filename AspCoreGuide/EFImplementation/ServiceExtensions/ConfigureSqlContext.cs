namespace EFImplementation.API.ServiceExtensions
{
    using EFImplementation.Repository;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ConfigureSqlContext
    {
        public static void ConfigureSql(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o=>o.UseSqlServer(connectionString));
        }
    }
}