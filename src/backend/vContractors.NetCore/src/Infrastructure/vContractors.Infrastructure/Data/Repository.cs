namespace vContractors.Infrastructure.Data
{
    public class Repository<T> : RepositoryBase<T> where T : class
    {
        public Repository(CoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
