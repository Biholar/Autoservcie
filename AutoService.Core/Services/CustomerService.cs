using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using AutoService.Core.Specs.CustomerCarSpec;
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

    public async Task<List<Customer>> GetCustomerCars()
    {
        return await _repository.ListAsync(new CustomerCarGetByCustomerId());
    }
    
    public async Task<List<Customer>> GetByNameAsync(string name)
    {
        var request = await _repository.ListAsync();
        var selectedRequest = request.Where(p => p.FirstName.StartsWith(name, StringComparison.OrdinalIgnoreCase) || p.SecondName.StartsWith(name, StringComparison.OrdinalIgnoreCase) ).OrderBy(p => p.Id);
        return selectedRequest.ToList();
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