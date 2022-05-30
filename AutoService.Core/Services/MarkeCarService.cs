using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using AutoService.Core.Specs.CarsSpec;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class MarkeCarService:IMarkeCarService
{
    private readonly IRepository<MarkeCar> _repository;

    public MarkeCarService(IRepository<MarkeCar> repository)
    {
        _repository = repository;
    }

    public async Task<List<MarkeCar>> GetAsync()
    {
        var res = await _repository.ListAsync();
        var sortedRes = res.OrderBy(p => p.Name);
        return sortedRes.ToList();
    }

    public async Task<List<MarkeCar>> GetByNameAsync(string name)
    {
        var request = await _repository.ListAsync();
        var selectedRequest = request.Where(p => p.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)).OrderBy(p => p.Name);
        return selectedRequest.ToList();
    }

       public async Task<MarkeCar> GetCarByIdIncludeModelModification(int id)
    {
        var request = await _repository.GetBySpecAsync(new CarModelModifIncludeSpecification(id));
        return request;
    }

    
    public async Task<MarkeCar> GetByIdAsync(int id)
    {
        var markeCar = await _repository.GetByIdAsync(id);
        if (markeCar == null) throw new NotFoundException(nameof(MarkeCar));

        return markeCar;
    }

    public async Task CreateAsync(MarkeCar markeCar)
    {
        await _repository.AddAsync(markeCar);
    }

    public async Task UpdateAsync(MarkeCar markeCar)
    {
        await _repository.UpdateAsync(markeCar);
    }

    public async Task DeleteAsync(int id)
    {
        var markeCar = await GetByIdAsync(id);
        await _repository.DeleteAsync(markeCar);
        
    }
}