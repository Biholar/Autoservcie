using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IServiceSpareService
{
    Task<List<ServiceSpare>> GetAsync();
    Task<ServiceSpare> GetByIdAsync(int id);
    Task CreateAsync(ServiceSpare serviceSpares);
    Task UpdateAsync(ServiceSpare serviceSpares);
    Task DeleteAsync(int id);
}