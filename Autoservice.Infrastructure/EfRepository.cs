using Ardalis.Specification.EntityFrameworkCore;
using Autoservice.Infrastructure.Data;

namespace Autoservice.Infrastructure;

public class EfRepository<T>: RepositoryBase<T>,  IRepository<T> where T : class
{
    
        public EfRepository(AutoserviceDbContext dbContext) : base(dbContext)
        {
        }
}