using API_IBGE_BALTA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_IBGE_BALTA.Data.Mappings
{
    public class LocationMapping : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("IBGE"); 
            builder.HasKey(e => e.Id); 
            builder.Property(e => e.City).IsRequired();
            builder.Property(e => e.State).IsRequired();
        }
    }
}
