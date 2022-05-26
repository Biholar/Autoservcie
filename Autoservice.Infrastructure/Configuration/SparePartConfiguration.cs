using Autoservice.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Autoservice.Infrastructure.Configuration;

public class SparePartConfiguration:IEntityTypeConfiguration<SparePart>
{
    public void Configure(EntityTypeBuilder<SparePart> builder)
    {
        builder
            .HasKey(x => x.Id);
    }
}