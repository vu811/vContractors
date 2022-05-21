using vContractors.Application.Interfaces;
using vContractors.Infrastructure.Data;

namespace vContractors.Infrastructure.Identity
{
    public class IdentityRepository<T> : RepositoryBase<T>, IRepository<T> where T : class
    {
        public IdentityRepository(AppIdentityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
