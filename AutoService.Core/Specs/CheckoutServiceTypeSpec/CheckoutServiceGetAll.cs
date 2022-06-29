using Ardalis.Specification;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Specs.CheckoutServiceTypeSpec;

public class CheckoutServiceGetAll:Specification<ServiceCheckout>
{
    public CheckoutServiceGetAll()
    {
        Query.Include(x => x.CustomerCar)
            .ThenInclude(x => x.Customer);
        Query.AsSplitQuery();   
        Query.Include(x => x.CustomerCar)
            .ThenInclude(x => x.Car)
            .ThenInclude(x => x.ModelCar)
            .ThenInclude(x => x.Marke);
        Query.AsSplitQuery();
        Query.Include(x => x.Master);
        Query.AsSplitQuery();
        Query.Include(x => x.ServiceTypeSumm)
            .ThenInclude(x=>x.ServiceType);
        
        Query.AsSplitQuery();
    }
}