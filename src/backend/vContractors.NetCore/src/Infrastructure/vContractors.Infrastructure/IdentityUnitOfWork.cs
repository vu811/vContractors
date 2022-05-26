using vContractors.Domain.Repositories;
using vContractors.Infrastructure.Identity;
using vContractors.Infrastructure.Repositories;

namespace vContractors.Infrastructure;

public class IdentityUnitOfWork : IIdentityUnitOfWork
{
    private readonly AppIdentityDbContext _dbContext;

    private IUserRepository _userRepository;

    public IdentityUnitOfWork(AppIdentityDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_dbContext);


    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
