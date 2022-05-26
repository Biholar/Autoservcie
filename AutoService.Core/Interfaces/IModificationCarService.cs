using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IModificationCarService
{
    Task<List<ModificationCar>> GetAsync();
    Task<ModificationCar> GetByIdAsync(int id);
    Task CreateAsync(ModificationCar modificationCar);
    Task UpdateAsync(ModificationCar  modificationCar);
    Task DeleteAsync(int id);
}