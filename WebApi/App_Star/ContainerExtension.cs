using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using Microsoft.Extensions.DependencyInjection;
using WBL;

namespace WebApi
{
    public static class ContainerExtension
    {
        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<IEmpleadoService, EmpleadoService>();
            services.AddTransient<IIdenticicacionServicio, IdentificacionServicio>();
            

            return services;
        }
    }
}
