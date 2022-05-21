using Microsoft.EntityFrameworkCore;

namespace vContractors.Infrastructure.Data
{
    public interface IUnitOfWork<T> where T : DbContext, IDisposable
    {
    }
}
