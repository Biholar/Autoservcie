using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IMasterService
{
    Task<List<Master>> GetAsync();
    Task<Master> GetByIdAsync(int id);
    Task<List<Master>> GetByNameAsync(string name);
    Task CreateAsync(Master master);
    Task UpdateAsync(Master master);
    Task DeleteAsync(int id);
}