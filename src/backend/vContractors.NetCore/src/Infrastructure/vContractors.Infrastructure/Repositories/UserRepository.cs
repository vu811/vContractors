using Microsoft.EntityFrameworkCore;
using vContractors.Domain.Entities.Identity;
using vContractors.Domain.Repositories;
using vContractors.Infrastructure.Identity;

namespace vContractors.Infrastructure.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    private readonly DbContext _dbContext;
    public UserRepository(AppIdentityDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User?> GetByUserNameAsync(string userName)
    {
        var user = await _dbContext.Set<User>().SingleOrDefaultAsync(p => p.UserName == userName);
        return user;
    }
}
