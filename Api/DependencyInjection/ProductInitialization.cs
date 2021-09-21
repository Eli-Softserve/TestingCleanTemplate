using Application;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Api.DependencyInjection
{
    public class ProductInitialization : Interfaces.IServiceCollectionInitialization
    {
        public void InitializeServices(IServiceCollection services, 
            Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);
            services.AddApplication(configuration);
        }
    }
}
