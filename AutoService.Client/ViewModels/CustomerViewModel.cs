using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class CustomerViewModel
{
    protected HttpClient _httpClient;

    public CustomerViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<CustomerDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<CustomerDto>>("https://localhost:44378/api/Customer");
    } 
    
    public async Task<List<CustomerDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<CustomerDto>>($"https://localhost:44378/api/Customer/name/{name}");
    }
    
   public async Task<List<CustomerCarsDto>> GetCustomerCars()
    {
        return await _httpClient.GetFromJsonAsync<List<CustomerCarsDto>>($"https://localhost:44378/api/Customer/customer-cars/");
    }
    
    public async Task<CustomerDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<CustomerDto>($"https://localhost:44378/api/Customer/{id}");
        return res;
    }

    public async Task Create(CustomerDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/Customer", entity);
    }

    public async Task Update(CustomerDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/Customer", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/Customer/{id}");
    }
}