using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ModificationCarService:IModificationCarService
{

    private readonly IRepository<ModificationCar> _repository;

    public ModificationCarService(IRepository<ModificationCar> repository)
    {
        _repository = repository;
    }

    public async Task<List<ModificationCar>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ModificationCar> GetByIdAsync(int id)
    {
        var modification = await _repository.GetByIdAsync(id);
        if (modification == null) throw new NotFoundException(nameof(ModificationCar));
        return modification;
    }

    public async Task CreateAsync(ModificationCar modificationCar)
    {
        await _repository.AddAsync(modificationCar);
    }

    public async Task UpdateAsync(ModificationCar modificationCar)
    {
        await _repository.UpdateAsync(modificationCar);
    }

    public async Task DeleteAsync(int id)
    {
        var modification = await GetByIdAsync(id);
        await _repository.DeleteAsync(modification);
    }
}