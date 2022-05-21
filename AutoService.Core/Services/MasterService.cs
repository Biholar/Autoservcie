using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class MasterService:IMasterService
{
    private readonly IRepository<Master> _repository;

    public MasterService(IRepository<Master> repository)
    {
        _repository = repository;
    }

    public async Task<List<Master>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<Master> GetByIdAsync(int id)
    {
        var master = await _repository.GetByIdAsync(id);
        if (master == null) throw new NotFoundException(nameof(Master));

        return master;
    }

    public async Task CreateAsync(Master master)
    {
        await _repository.AddAsync(master);
    }

    public async Task UpdateAsync(Master master)
    {
        await _repository.UpdateAsync(master);
    }

    public async Task DeleteAsync(int id)
    {
        var master = await GetByIdAsync(id);
        await _repository.DeleteAsync(master);
    }
}