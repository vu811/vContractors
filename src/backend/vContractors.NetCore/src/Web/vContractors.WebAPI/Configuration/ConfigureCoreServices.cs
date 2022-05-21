using vContractors.Application.Interfaces;
using vContractors.Application.Services;
using vContractors.Infrastructure.Identity;

namespace vContractors.WebAPI.Configuration
{
    public static  class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(IdentityRepository<>));
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
