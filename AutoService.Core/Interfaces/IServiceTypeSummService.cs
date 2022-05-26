using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IServiceTypeSummService
{
    Task<List<ServiceTypeSumm>> GetAsync();
    Task<ServiceTypeSumm> GetByIdAsync(int id);
    Task CreateAsync(ServiceTypeSumm serviceTypeSumm);
    Task UpdateAsync(ServiceTypeSumm serviceTypeSumm);
    Task DeleteAsync(int id);
}