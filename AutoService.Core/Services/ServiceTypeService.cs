using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ServiceTypeService:IServiceTypeService
{
    private readonly IRepository<ServiceType> _repository;

    public ServiceTypeService(IRepository<ServiceType> repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceType>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ServiceType> GetByIdAsync(int id)
    {
        var serviceType = await _repository.GetByIdAsync(id);
        if (serviceType == null) throw new NotFoundException(nameof(ServiceType));

        return serviceType;
    }

    public async Task CreateAsync(ServiceType serviceType)
    {
        await _repository.AddAsync(serviceType);
    }

    public async Task UpdateAsync(ServiceType serviceType)
    {
        await _repository.UpdateAsync(serviceType);
    }

    public async Task DeleteAsync(int id)
    {
        var serviceType = await GetByIdAsync(id);
        await _repository.DeleteAsync(serviceType);
    }
}