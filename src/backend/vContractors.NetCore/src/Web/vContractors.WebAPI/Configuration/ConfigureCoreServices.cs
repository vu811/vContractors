using vContractors.Application.Interfaces;
using vContractors.Application.Services;
using vContractors.Domain.Repositories;
using vContractors.Infrastructure;
using vContractors.Infrastructure.Repositories;

namespace vContractors.WebAPI.Configuration
{
    public static  class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddTransient<IIdentityUnitOfWork, IdentityUnitOfWork>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
