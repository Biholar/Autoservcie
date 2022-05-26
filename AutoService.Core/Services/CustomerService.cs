using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class CustomerService:ICustomerService
{
    private readonly IRepository<Customer> _repository;

    public CustomerService(IRepository<Customer> repository)
    {
        _repository = repository;
    }


    public async Task<List<Customer>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<Customer> GetByIdAsync(int id)
    {
        var customer = await _repository.GetByIdAsync(id);
        if (customer == null) throw new NotFoundException(nameof(Customer));

        return customer;
    }

    public async Task CreateAsync(Customer customer)
    {
        await _repository.AddAsync(customer);
    }

    public async Task UpdateAsync(Customer customer)
    {
        await _repository.UpdateAsync(customer);
    }

    public async Task DeleteAsync(int id)
    {
        var customer = await GetByIdAsync(id);
        await _repository.DeleteAsync(customer);
    }
}