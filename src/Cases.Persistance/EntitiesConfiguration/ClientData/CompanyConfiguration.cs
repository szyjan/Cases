using Cases.Domain.Entities.ClientData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.ClientData
{
    internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Representatives)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CustomerId);

            builder
                .HasMany(x => x.CompanyIdentifiers)
                .WithOne()
                .HasForeignKey(x => x.CompanyId);

            //Change trackable stuff
            builder
                .HasOne(x => x.CreatedByEmployee)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy);

            builder
                .HasOne(x => x.ModifiedByEmployee)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy);
        }
    }
}
