using Api.DependencyInjection.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Api.DependencyInjection
{
    public static class InitializeAllServiceCollection
    {
        public static void InitializeServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var ServiceCollectionInitialization = typeof(Startup).Assembly.ExportedTypes
                .Where(x => typeof(IServiceCollectionInitialization).IsAssignableFrom(x) && !x.IsInterface &&
                            !x.IsAbstract).Select(Activator.CreateInstance).Cast<IServiceCollectionInitialization>().ToList();
            
            ServiceCollectionInitialization.ForEach(
                initialize => initialize.InitializeServices(services, configuration));
        }
    }
}
