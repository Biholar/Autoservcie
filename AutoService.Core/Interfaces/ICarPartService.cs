using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface ICarPartService
{
    Task<List<CarPart>> GetAsync();
    Task<CarPart> GetByIdAsync(int id);
    Task CreateAsync(CarPart carPart);
    Task UpdateAsync(CarPart carPart);
    Task DeleteAsync(int id);
}