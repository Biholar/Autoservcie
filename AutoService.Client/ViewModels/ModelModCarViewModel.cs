using Autoservice.Infrastructure.Models;
using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class ModelModCarViewModel
{
    protected HttpClient _httpClient;

    public ModelModCarViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<ModelCarDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<ModelCarDto>>("https://localhost:44378/api/MarkeCar");
    } 
    
    public async Task<MarkeCar> GetCar(int id)
    {
        return await _httpClient.GetFromJsonAsync<MarkeCar>($"https://localhost:44378/api/MarkeCar/modelbymarke/{id}");
    }
    
    public async Task<ModelCarDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<ModelCarDto>($"https://localhost:44378/api/MarkeCar/{id}");
        return res;
    }

    public async Task Create(ModelCarDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/MarkeCar", entity);
    }

    public async Task Update(ModelCarDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/MarkeCar", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/MarkeCar/{id}");
    }
}