using vContractors.Infrastructure.Data;

namespace vContractors.Infrastructure.Repositories;

public class Repository<T> : RepositoryBase<T> where T : class
{
    public Repository(CoreDbContext dbContext) : base(dbContext)
    {
    }
}
