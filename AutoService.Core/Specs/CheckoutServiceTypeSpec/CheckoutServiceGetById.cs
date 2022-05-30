using Ardalis.Specification;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Specs.CheckoutServiceTypeSpec;

public class CheckoutServiceGetById:Specification<ServiceTypeSumm>, ISingleResultSpecification<ServiceTypeSumm>
{
    public CheckoutServiceGetById(int id)
    {
        Query.Where(x => x.ServiceCheckoutId == id)
            .Include(x => x.ServiceCheckout)
            .ThenInclude(x => x.CustomerCar)
            .ThenInclude(x => x.Customer);
            
        
        Query.Include(x => x.ServiceCheckout)
            .ThenInclude(x => x.CustomerCar)
            .ThenInclude(x => x.Car)
            .ThenInclude(x => x.ModelCar)
            .ThenInclude(x => x.Marke);
        
        Query.Include(x => x.ServiceCheckout)
            .ThenInclude(x => x.Master);

        Query.Include(x => x.ServiceType);
        
        Query.AsSplitQuery();
    }
}