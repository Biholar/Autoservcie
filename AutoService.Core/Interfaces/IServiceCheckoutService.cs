using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IServiceCheckoutService
{
    Task<List<ServiceCheckout>> GetAsync();
    Task<ServiceCheckout> GetByIdAsync(int id);
    Task CreateAsync(ServiceCheckout serviceCheckout);
    Task<List<ServiceCheckout>> GetAllInclude();
    Task UpdateAsync(ServiceCheckout serviceCheckout);
    Task DeleteAsync(int id);
}