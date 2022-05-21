using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class SparePartService:ISparePartService
{
    private readonly IRepository<SparePart> _repository;

    public SparePartService(IRepository<SparePart> repository)
    {
        _repository = repository;
    }

    public async Task<List<SparePart>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<SparePart> GetByIdAsync(int id)
    {
        var sparePart = await _repository.GetByIdAsync(id);
        if (sparePart == null) throw new NotFoundException(nameof(SparePart));

        return sparePart;
    }

    public async Task CreateAsync(SparePart sparePart)
    {
        await _repository.AddAsync(sparePart);
    }

    public async Task UpdateAsync(SparePart sparePart)
    {
        await _repository.UpdateAsync(sparePart);
    }

    public async Task DeleteAsync(int id)
    {
        var sparePart = await GetByIdAsync(id);
        await _repository.DeleteAsync(sparePart);
    }
}