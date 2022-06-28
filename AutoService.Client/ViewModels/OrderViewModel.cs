using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class OrderViewModel
{
    protected HttpClient _httpClient;

    public OrderViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<ServiceCheckoutDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceCheckoutDto>>("https://localhost:44378/api/ServiceCheckout");
    } 
    
    public async Task<ServiceCheckoutDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ServiceCheckoutDto>($"https://localhost:44378/api/ServiceCheckout/{id}");
        return res;
    }

    public async Task Create(ServiceCheckoutDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/ServiceCheckout", entity);
    }

    public async Task Update(ServiceCheckoutDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceCheckout", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/ServiceCheckout/{id}");
    }
}