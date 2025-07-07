using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DiligenciaProveedores.Domain.Entities;
using DiligenciaProveedores.Domain.Enums;

namespace DiligenciaProveedores.Persistence.Configurations;

public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
{
    public void Configure(EntityTypeBuilder<Provider> builder)
    {
        builder.ToTable("Providers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.BusinessName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.TradeName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.TaxId)
            .IsRequired()
            .HasMaxLength(11)
            .IsUnicode(false);

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Website)
            .HasMaxLength(250);

        builder.Property(p => p.Address)
            .HasMaxLength(300);

        builder.Property(p => p.Country)
            .HasConversion(
                v => v.ToString(),
                v => Enum.IsDefined(typeof(Country), v) ? (Country)Enum.Parse(typeof(Country), v) : Country.Otro)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.AnnualBillingUSD)
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.LastModified)
            .IsRequired();
    }
}
