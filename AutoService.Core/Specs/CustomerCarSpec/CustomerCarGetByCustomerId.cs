using Ardalis.Specification;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Specs.CustomerCarSpec;

public class CustomerCarGetByCustomerId:Specification<Customer>
{

    public CustomerCarGetByCustomerId()
    {
        Query.Include(x => x.CustomerCars)
            .ThenInclude(x => x.Car)
            .ThenInclude(x => x.ModelCar)
            .ThenInclude(x=>x.Marke);
    }
}