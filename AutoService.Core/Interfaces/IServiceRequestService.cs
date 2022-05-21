using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IServiceRequestService
{
    Task<List<ServiceRequest>> GetAsync();
    Task<ServiceRequest> GetByIdAsync(int id);
    Task CreateAsync(ServiceRequest serviceRequest);
    Task UpdateAsync(ServiceRequest  serviceRequest);
    Task DeleteAsync(int id);
}