using Ardalis.Specification;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Specs.CarsSpec;

public class CarModelModifIncludeSpecification:Specification<MarkeCar>, ISingleResultSpecification<MarkeCar>
{
    public CarModelModifIncludeSpecification(int id)
    {
        
        Query
            .Where(p => p.Id == id)
            .Include(p => p.ModelCars)
            .ThenInclude(p=>p.ModificationCars);
    }
}