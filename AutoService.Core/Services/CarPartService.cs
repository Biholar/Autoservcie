using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class CarPartService:ICarPartService
{
    private readonly IRepository<CarPart> _repository;

    public CarPartService(IRepository<CarPart> repository)
    {
        _repository = repository;
    }

    public async Task<List<CarPart>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<CarPart> GetByIdAsync(int id)
    {
        var carPart = await _repository.GetByIdAsync(id);
        if (carPart == null) throw new NotFoundException(nameof(CarPart));

        return carPart;
    }

    public async Task CreateAsync(CarPart carPart)
    {
        await _repository.AddAsync(carPart);
    }

    public async Task UpdateAsync(CarPart carPart)
    {
        await _repository.UpdateAsync(carPart);
    }

    public async Task DeleteAsync(int id)
    {
        var carPart = await GetByIdAsync(id);
        await _repository.DeleteAsync(carPart);
    }
}