using Microsoft.EntityFrameworkCore;

namespace vContractors.Infrastructure.Data
{
    abstract class UnitOfWorkBase<T> where T : DbContext
    {
        private readonly T _dbContext;

        public UnitOfWorkBase(T dbContext)
        {
            _dbContext = dbContext;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
