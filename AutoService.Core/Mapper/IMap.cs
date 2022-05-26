using AutoMapper;

namespace AutoService.Core.Mapper;

public interface IMap<T>
{
    void Mapping(Profile profile)
    {
        profile.CreateMap(typeof(T), GetType(), MemberList.Destination).DisableCtorValidation();
        profile.CreateMap (GetType(),typeof(T), MemberList.Destination).DisableCtorValidation();
    } 
}