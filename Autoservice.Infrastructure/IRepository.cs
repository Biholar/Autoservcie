using Ardalis.Specification;

namespace Autoservice.Infrastructure;

public interface IRepository<T>: IRepositoryBase<T> where T : class
{
    
}