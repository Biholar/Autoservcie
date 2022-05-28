using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class MarkeCarViewModel
{
    protected HttpClient _httpClient;

    public MarkeCarViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<MarkeCarDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<MarkeCarDto>>("https://localhost:44378/api/MarkeCar");
    } 
    
    public async Task<List<MarkeCarDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<MarkeCarDto>>($"https://localhost:44378/api/MarkeCar/marke/{name}");
    }
    
    public async Task<MarkeCarDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<MarkeCarDto>($"https://localhost:44378/api/MarkeCar/{id}");
        return res;
    }

    public async Task Create(MarkeCarDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/MarkeCar", entity);
    }

    public async Task Update(MarkeCarDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/MarkeCar", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/MarkeCar/{id}");
    }
}