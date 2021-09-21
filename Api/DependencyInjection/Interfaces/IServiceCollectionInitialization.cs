using Microsoft.Extensions.DependencyInjection;

namespace Api.DependencyInjection.Interfaces
{
    public interface IServiceCollectionInitialization
    {
        void InitializeServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration);
    }
}
