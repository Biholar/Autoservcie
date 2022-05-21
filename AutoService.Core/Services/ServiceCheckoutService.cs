using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ServiceCheckoutService:IServiceCheckoutService
{
    private readonly IRepository<ServiceCheckout> _repository;
    
    public ServiceCheckoutService(IRepository<ServiceCheckout> repository)
    {
        _repository = repository;
    }

    
    public async Task<List<ServiceCheckout>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ServiceCheckout> GetByIdAsync(int id)
    {
        var serviceCheckout = await _repository.GetByIdAsync(id);
        if (serviceCheckout == null) throw new NotFoundException(nameof(ServiceCheckout));

        return serviceCheckout;
    }

    public async Task CreateAsync(ServiceCheckout serviceCheckout)
    {
        await _repository.AddAsync(serviceCheckout);
    }

    public async Task UpdateAsync(ServiceCheckout serviceCheckout)
    {
        await _repository.UpdateAsync(serviceCheckout);
    }

    public async Task DeleteAsync(int id)
    {
        var serviceCheckout = await GetByIdAsync(id);
        await _repository.DeleteAsync(serviceCheckout);
    }
}