using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IModelCarService
{
    Task<List<ModelCar>> GetAsync();
    Task<ModelCar> GetByIdAsync(int id);
    Task CreateAsync(ModelCar modelCar);
    Task UpdateAsync(ModelCar  modelCar);
    Task DeleteAsync(int id);
}