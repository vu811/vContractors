using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using vContractors.Infrastructure.Data;
using vContractors.Infrastructure.Identity;

namespace vContractors.Infrastructure;

public static class Dependencies
{
    public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
        services.AddDbContext<CoreDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CoreDbConnection")));
        services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("IdentityConnection")));
    }
}
