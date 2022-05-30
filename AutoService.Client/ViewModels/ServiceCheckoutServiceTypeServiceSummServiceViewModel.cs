using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class ServiceCheckoutServiceTypeServiceSummServiceViewModel
{
    protected HttpClient _httpClient;

    public ServiceCheckoutServiceTypeServiceSummServiceViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<ServiceCheckoutServiceTypeDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceCheckoutServiceTypeDto>>("https://localhost:44378/api/ServiceTypeSumm/service-checout-table");
    } 
    
    
    public async Task<ServiceCheckoutServiceTypeDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ServiceCheckoutServiceTypeDto>($"https://localhost:44378/api/ServiceTypeSumm/service-checout-table/{id}");
        return res;
    }

    public async Task Create(ServiceCheckoutServiceTypeDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/ServiceTypeSumm/service-checout-table", entity);
    }

    public async Task Update(ServiceCheckoutServiceTypeDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceTypeSumm/service-checout-table", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/ServiceTypeSumm/service-checout-table/{id}");
    }
}