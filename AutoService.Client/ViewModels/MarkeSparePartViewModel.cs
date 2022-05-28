using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class SparePartViewModel
{
    protected HttpClient _httpClient;

    public SparePartViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<SparePartDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<SparePartDto>>("https://localhost:44378/api/SparePart");
    } 
    
    public async Task<List<SparePartDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<SparePartDto>>($"https://localhost:44378/api/SparePart/spare/{name}");
    }
    
    public async Task<SparePartDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<SparePartDto>($"https://localhost:44378/api/SparePart/{id}");
        return res;
    }

    public async Task Create(SparePartDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/SparePart", entity);
    }

    public async Task Update(SparePartDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/SparePart", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/SparePart/{id}");
    }
}