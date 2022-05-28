using AutoService.WEBAPI.Dto;

namespace AutoService.Client.ViewModels;

public class MasterViewModel
{
    protected HttpClient _httpClient;

    public MasterViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<MasterDto>> Get()
    {
        return await _httpClient.GetFromJsonAsync<List<MasterDto>>("https://localhost:44378/api/Master");
    } 
    
    public async Task<List<MasterDto>> GetByName(string name)
    {
        return await _httpClient.GetFromJsonAsync<List<MasterDto>>($"https://localhost:44378/api/Master/name/{name}");
    }
    
    public async Task<MasterDto> GetById(int id)
    {
        var res = await _httpClient.GetFromJsonAsync<MasterDto>($"https://localhost:44378/api/Master/{id}");
        return res;
    }

    public async Task Create(MasterDto entity)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:44378/api/Master", entity);
    }

    public async Task Update(MasterDto entity)
    {
        await _httpClient.PutAsJsonAsync("https://localhost:44378/api/Master", entity);
    }
    
    public async Task Delete(int id)
    {
        await _httpClient.DeleteAsync($"https://localhost:44378/api/Master/{id}");
    }
}