namespace vContractors.Domain.Repositories;

public interface IRepositoryBase<T> : IReadRepositoryBase<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
    void Update(T entity);
    Task UpdateRange(IEnumerable<T> entities);
    Task DeleteAsync(T entity);
    Task DeleteRangeAsync(IEnumerable<T> entities);

    Task<int> SaveChangesAsync();
}
