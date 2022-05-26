using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
using AutoService.Core.Specs.ServiceRequestSpec;
using Autoservice.Infrastructure;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Services;

public class ServiceRequestService:IServiceRequestService
{
    private readonly IRepository<ServiceRequest> _repository;

    public ServiceRequestService(IRepository<ServiceRequest> repository)
    {
        _repository = repository;
    }

    public async Task<List<ServiceRequest>> GetAsync()
    {
        return await _repository.ListAsync();
    }

    public async Task<ServiceRequest> GetByIdAsync(int id)
    {
        var request = await _repository.GetByIdAsync(id);
        if (request == null) throw new NotFoundException(nameof(ServiceRequest));

        return request;
    }

    public async Task<List<ServiceRequest>> GetByStateAsync(int state)
    {
        var request = await _repository.ListAsync(new ServiceRequestGetByStateSpec(state));
        return request;
    }

    public async Task<List<ServiceRequest>> GetByNameAsync(string name)
    {
        var request = await _repository.ListAsync();
        var selectedRequest = request.Where(p => p.SecondName.Contains(name, StringComparison.OrdinalIgnoreCase)).OrderBy(p => p.Id);
        return selectedRequest.ToList();
    }

    public async Task CreateAsync(ServiceRequest serviceRequest)
    {
        await _repository.AddAsync(serviceRequest);
    }

    public async Task UpdateAsync(ServiceRequest serviceRequest)
    {
        await _repository.UpdateAsync(serviceRequest);
    }
    
    public async Task UpdateStateAsync(ServiceRequest serviceRequest)
    {
        var res = await GetByIdAsync(serviceRequest.Id);
        res.Statement = serviceRequest.Statement;
        await _repository.UpdateAsync(res);
    }

    public async Task DeleteAsync(int id)
    {
        var serviceRequest = await GetByIdAsync(id);
        await _repository.DeleteAsync(serviceRequest); 
    }
}