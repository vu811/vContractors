namespace vContractors.Domain.Repositories;
public interface IReadRepositoryBase<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();
}
