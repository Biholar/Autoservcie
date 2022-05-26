
using AutoService.WEBAPI.Controllers;
using AutoService.WEBAPI.Dto;


namespace AutoService.Client.ViewModels;

public class ServiceRequestViewModel
{
    protected HttpClient _httpClient;
    
    public ServiceRequestViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
  
    public async Task<List<ServiceRequestDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceRequestDto>>("https://localhost:44378/api/ServiceRequest");
    } 
    
    public async Task<List<ServiceRequestDto>> GetByState(int id)
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceRequestDto>>($"https://localhost:44378/api/ServiceRequest/requestState/{id}");
    }
    
    public async Task<List<ServiceRequestDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceRequestDto>>($"https://localhost:44378/api/ServiceRequest/requestName/{name}");
    }
    
    public async Task<ServiceRequestDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ServiceRequestDto>($"https://localhost:44378/api/ServiceRequest/{id}");
        return res;
    }

    public async Task Create(ServiceRequestDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/ServiceRequest", entity);
    }

    public async Task Update(ServiceRequestDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceRequest", entity);
    }
    
     public async Task UpdateState(ServiceUpdateRequestDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceRequest/state-update", entity);
    }
    
    public async Task Delete(int id)
    {
        
            await _httpClient.DeleteAsync($"https://localhost:44378/api/ServiceRequest/{id}");
      
    }
}