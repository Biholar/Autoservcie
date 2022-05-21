using AutoService.Core.Services;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface IMarkeCarService
{
    Task<List<MarkeCar>> GetAsync();
    Task<MarkeCar> GetByIdAsync(int id);
    Task CreateAsync(MarkeCar markeCar);
    Task UpdateAsync(MarkeCar  markeCar);
    Task DeleteAsync(int id);
}