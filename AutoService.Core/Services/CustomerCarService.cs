using Ardalis.Specification;
using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using AutoService.Core.Specs.CustomerCarSpec;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class CustomerCarService:ICustomerCarService
{
    private readonly IRepository<CustomerCar> _repository;

    public CustomerCarService(IRepository<CustomerCar> repository)
    {
        _repository = repository;
    }

    public async Task<List<CustomerCar>> GetAsync()
    {
        return await _repository.ListAsync();
    }

  

    public async Task<CustomerCar> GetByIdAsync(int id)
    {
        var customerCar = await _repository.GetByIdAsync(id);
        if (customerCar == null) throw new NotFoundException(nameof(CustomerCar));

        return customerCar;
    }

    public async Task CreateAsync(CustomerCar customerCar)
    {
        await _repository.AddAsync(customerCar);
    }

    public async Task UpdateAsync(CustomerCar customerCar)
    {
        await _repository.UpdateAsync(customerCar);
    }

    public async Task DeleteAsync(int id)
    {
        var customerCar = await GetByIdAsync(id);
        await _repository.DeleteAsync(customerCar);
    }
}