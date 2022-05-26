using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface  IServiceRequestService
{
    Task<List<ServiceRequest>> GetAsync();
    Task<ServiceRequest> GetByIdAsync(int id);
    Task <List<ServiceRequest>> GetByStateAsync(int state);
    Task <List<ServiceRequest>> GetByNameAsync(string name);
    Task CreateAsync(ServiceRequest serviceRequest);
    Task UpdateAsync(ServiceRequest  serviceRequest);
    Task UpdateStateAsync(ServiceRequest serviceRequest);
    Task DeleteAsync(int id);
}