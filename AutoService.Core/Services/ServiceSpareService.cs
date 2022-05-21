using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ServiceSpareService:IServiceSpareService
{
    private readonly IRepository<ServiceSpare> _repository;

    public ServiceSpareService(IRepository<ServiceSpare> repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceSpare>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ServiceSpare> GetByIdAsync(int id)
    {
        var serviceSpare = await _repository.GetByIdAsync(id);
        if (serviceSpare == null) throw new NotFoundException(nameof(ServiceSpare));

        return serviceSpare;
    }

    public async Task CreateAsync(ServiceSpare serviceSpares)
    {
        await _repository.AddAsync(serviceSpares);
    }

    public async Task UpdateAsync(ServiceSpare serviceSpares)
    {
        await _repository.UpdateAsync(serviceSpares);
    }

    public async Task DeleteAsync(int id)
    {
        var serviceSpares = await GetByIdAsync(id);
        await _repository.DeleteAsync(serviceSpares);
    }
}