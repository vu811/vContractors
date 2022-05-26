using vContractors.Domain.Entities.Identity;

namespace vContractors.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByUserNameAsync(string userName);
    }
}
