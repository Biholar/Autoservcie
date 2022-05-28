using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class ServiceTypeViewModel
{
    protected HttpClient _httpClient;

    public ServiceTypeViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<ServiceTypeDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceTypeDto>>("https://localhost:44378/api/ServiceType");
    } 
    
    public async Task<List<ServiceTypeDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<ServiceTypeDto>>($"https://localhost:44378/api/ServiceType/requestName/{name}");
    }
    
    public async Task<ServiceTypeDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ServiceTypeDto>($"https://localhost:44378/api/ServiceType/{id}");
        return res;
    }

    public async Task Create(ServiceTypeDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/ServiceType", entity);
    }

    public async Task Update(ServiceTypeDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/ServiceType", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/ServiceType/{id}");
    }
}