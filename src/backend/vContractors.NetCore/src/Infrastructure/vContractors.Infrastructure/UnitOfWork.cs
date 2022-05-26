using vContractors.Domain.Repositories;
using vContractors.Infrastructure.Data;

namespace vContractors.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly CoreDbContext _dbContext;

    public UnitOfWork(CoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }
    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
