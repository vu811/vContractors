using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using vContractors.Domain.Entities.Identity;

namespace vContractors.Infrastructure.Identity;

public class AppIdentityDbContextSeed
{
    public static async Task SeedAsync(AppIdentityDbContext identityDbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {

        if (identityDbContext.Database.IsSqlServer())
        {
            identityDbContext.Database.Migrate();
        }

        await roleManager.CreateAsync(new IdentityRole("Administrators"));

        var defaultUser = new User { UserName = "vunh811@gmail.com", Email = "vunh811@gmail.com" };
        await userManager.CreateAsync(defaultUser, "Pass@word1");

        string adminUserName = "admin@nhathauviet.vn";
        var adminUser = new User { UserName = adminUserName, Email = adminUserName };
        await userManager.CreateAsync(adminUser, "Pass@word1");
        adminUser = await userManager.FindByNameAsync(adminUserName);
        await userManager.AddToRoleAsync(adminUser, "Administrators");
    }
}

