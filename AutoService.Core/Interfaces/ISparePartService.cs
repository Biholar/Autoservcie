using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Interfaces;

public interface ISparePartService
{
    Task<List<SparePart>> GetAsync();
    Task<SparePart> GetByIdAsync(int id);
    Task CreateAsync(SparePart sparePart);
    Task UpdateAsync(SparePart sparePart);
    Task DeleteAsync(int id);
}