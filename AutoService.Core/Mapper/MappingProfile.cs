namespace AutoService.Core.Mapper;
using System.Reflection;
using System.Runtime.Serialization;
using AutoMapper;

public class MappingProfile:Profile
{
    
    public MappingProfile(IEnumerable<Assembly> assemblies)
    {
        AllowNullCollections = true;
        foreach (var assembly in assemblies)
        {
            ApplyMappingsFromAssembly(assembly);
        }
    }

    public MappingProfile()
    {
        AllowNullCollections = true;
        ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        ApplyMappingsFromAssembly(Assembly.GetEntryAssembly());
    }

    private void ApplyMappingsFromAssembly(Assembly assembly)
    {
        var typesWithMap = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMap<>)))
            .ToList();

        foreach (var type in typesWithMap)
        {
            var instance = FormatterServices.GetUninitializedObject(type);

            var methodInfo = type.GetMethod("Mapping")
                             ?? type.GetInterface("IMap`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }
}