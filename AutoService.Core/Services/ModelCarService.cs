using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ModelCarService:IModelCarService
{
    private readonly IRepository<ModelCar> _repository;

    public ModelCarService(IRepository<ModelCar> repository)
    {
        _repository = repository;
    }

    public async Task<List<ModelCar>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ModelCar> GetByIdAsync(int id)
    {
        var modelCar = await _repository.GetByIdAsync(id);
        if (modelCar == null) throw new NotFoundException(nameof(ModelCar));

        return modelCar;
    }

    public async Task CreateAsync(ModelCar modelCar)
    {
        await _repository.AddAsync(modelCar);
    }

    public async Task UpdateAsync(ModelCar modelCar)
    {
        await _repository.UpdateAsync(modelCar);
    }

    public async Task DeleteAsync(int id)
    {
        var markeCar = await GetByIdAsync(id);
        await _repository.DeleteAsync(markeCar);   
    }
}