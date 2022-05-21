using Microsoft.EntityFrameworkCore;

namespace vContractors.Infrastructure.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {

    }
}
