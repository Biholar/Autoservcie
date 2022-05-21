using AutoService.Core.Exceptions;
using AutoService.Core.Interfaces;
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

    public async Task CreateAsync(ServiceRequest serviceRequest)
    {
        await _repository.AddAsync(serviceRequest);
    }

    public async Task UpdateAsync(ServiceRequest serviceRequest)
    {
        await _repository.UpdateAsync(serviceRequest);
    }

    public async Task DeleteAsync(int id)
    {
        var serviceRequest = await GetByIdAsync(id);
        await _repository.DeleteAsync(serviceRequest); 
    }
}