using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface ICustomerCarService
{
    Task<List<CustomerCar>> GetAsync();
    Task<CustomerCar> GetByIdAsync(int id);
    Task CreateAsync(CustomerCar customerCar);
    Task UpdateAsync(CustomerCar customerCar);
    Task DeleteAsync(int id);
}