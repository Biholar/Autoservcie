using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using AutoService.Core.Specs.CheckoutServiceTypeSpec;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ServiceTypeSummService:IServiceTypeSummService
{
    private readonly IRepository<ServiceTypeSumm> _repository;
    private readonly IRepository<CustomerCar> _customerCar;

    public ServiceTypeSummService(IRepository<ServiceTypeSumm> repository, IRepository<CustomerCar> customerCar)
    {
        _repository = repository;
        _customerCar = customerCar;
    }

    public async Task<List<ServiceTypeSumm>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ServiceTypeSumm> GetByIdAsync(int id)
    {
        var serviceTypeSumm = await _repository.GetByIdAsync(id);
        if (serviceTypeSumm == null) throw new NotFoundException(nameof(ServiceTypeSumm));

        return serviceTypeSumm;
    }

    public async Task<ServiceTypeSumm> GetByIdInclude(int id)
    {
        return await _repository.GetBySpecAsync(new CheckoutServiceGetById(id));
    }
     
    
    public async Task CreateAsync(ServiceTypeSumm serviceTypeSumm)
    {
        await _repository.AddAsync(serviceTypeSumm);
    }

    public async Task UpdateAsync(ServiceTypeSumm serviceTypeSumm)
    {
        await _repository.UpdateAsync(serviceTypeSumm);
    }

    public async Task DeleteAsync(int id)
    {
        var ServiceTypeSumm = await GetByIdAsync(id);
        await _repository.DeleteAsync(ServiceTypeSumm);
    }
}