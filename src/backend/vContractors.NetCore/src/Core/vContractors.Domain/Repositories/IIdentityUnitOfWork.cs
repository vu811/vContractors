
namespace vContractors.Domain.Repositories;

public interface IIdentityUnitOfWork : IDisposable
{
    IUserRepository Users { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
