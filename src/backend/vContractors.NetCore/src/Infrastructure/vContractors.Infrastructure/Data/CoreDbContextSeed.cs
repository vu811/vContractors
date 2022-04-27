using Microsoft.EntityFrameworkCore;
using vContractors.Domain.Entitties.Projects;

namespace vContractors.Infrastructure.Data;

public class CoreDbContextSeed
{
    public static async Task SeedAsync(CoreDbContext coreDbContext)
    {
        if (coreDbContext.Database.IsSqlServer())
        {
            coreDbContext.Database.Migrate();
        }

        if (!await coreDbContext.Projects.AnyAsync())
        {
            await coreDbContext.Projects.AddRangeAsync(GetProjects());

            await coreDbContext.SaveChangesAsync();
        }
    }

    private static IEnumerable<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project { Title="Project 1", Location="Dalat", Area=120, Type="Nha cap 4" }
        };
    }
}
