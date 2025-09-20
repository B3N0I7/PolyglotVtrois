using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polyglot.Core.Interfaces;
using Polyglot.Gateway.Configurations;
using Polyglot.Gateway.Contexts;
using Polyglot.Gateway.Repositories;

namespace Polyglot.Gateway
{
    public static class GatewayServiceCollectionExtensions
    {
        public static IServiceCollection AddGateway(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<MongoDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            
            return services;
        }
    }
}
