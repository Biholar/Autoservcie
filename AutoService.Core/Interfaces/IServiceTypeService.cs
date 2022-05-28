using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IServiceTypeService
{
    Task<List<ServiceType>> GetAsync();
    Task<ServiceType> GetByIdAsync(int id);
    Task<List<ServiceType>> GetByNameAsync(string name);
    Task CreateAsync(ServiceType serviceType);
    Task UpdateAsync(ServiceType serviceType);
    Task DeleteAsync(int id);
}