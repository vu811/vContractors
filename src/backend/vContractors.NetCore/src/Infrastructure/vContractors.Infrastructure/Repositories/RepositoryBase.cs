using Microsoft.EntityFrameworkCore;
using vContractors.Domain.Repositories;

namespace vContractors.Infrastructure.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly DbContext _dbContext;

    public RepositoryBase(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<List<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public Task<T> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Update(T entity)
    {
       _dbContext.Update(entity);
    }

    public Task UpdateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }
}
