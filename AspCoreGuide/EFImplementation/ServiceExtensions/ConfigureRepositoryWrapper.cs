using EFImplementation.Repository.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFImplementation.API.ServiceExtensions
{
    public static class ConfigureRepositoryWrapper
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
