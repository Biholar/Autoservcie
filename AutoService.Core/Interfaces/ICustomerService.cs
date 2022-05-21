using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface ICustomerService
{
    Task<List<Customer>> GetAsync();
    Task<Customer> GetByIdAsync(int id);
    Task CreateAsync(Customer customer);
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(int id);
}