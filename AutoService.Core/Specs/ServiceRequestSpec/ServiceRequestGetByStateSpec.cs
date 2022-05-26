using Ardalis.Specification;
using Autoservice.Infrastructure.Models;

namespace AutoService.Core.Specs.ServiceRequestSpec;

public class ServiceRequestGetByStateSpec:Specification<ServiceRequest>
{
    public ServiceRequestGetByStateSpec(int state)
    {
        Query.Where(p => p.Statement == state).OrderBy(p => p.Id);
    }
}