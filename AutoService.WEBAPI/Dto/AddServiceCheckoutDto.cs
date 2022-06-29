using AutoMapper;
using AutoService.Core.Mapper;
using Autoservice.Infrastructure.Models;

namespace AutoService.WEBAPI.Dto;

public class AddServiceCheckoutDto:IMap<ServiceCheckout>
{
    public int CustomerCarId { get; set; }
    public string ProblemDesc { get; set; }
    public int ServiceStatus { get; set; }
    public List<int> ServiceTypeId { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<AddServiceCheckoutDto, ServiceCheckout>()
            .ForMember(d => d.ServiceTypeSumm, m =>
                m.MapFrom(s => s.ServiceTypeId.Select(x => new ServiceTypeSumm() {ServiceTypeId = x}).ToList()
                ));
    }
}