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
        return await _httpClient.GetFromJsonAsync<List<ServiceCheckoutServiceTypeDto>>("https://localhost:44378/api/ServiceCheckout/service-checkout-table");
    } 
    
    
    public async Task<ServiceCheckoutServiceTypeDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ServiceCheckoutServiceTypeDto>($"https://localhost:44378/api/ServiceCheckout/service-checkout-table/{id}");
        return res;
    }

    public async Task Create(AddServiceCheckoutDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/ServiceCheckout/service-checkout-table", entity);
    }

    public async Task Update(AddServiceCheckoutDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceCheckout/service-checkout-table", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/ServiceTypeSumm/service-checkout-table/{id}");
    }
}