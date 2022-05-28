using Cases.Domain.Entities.ClientData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.ClientData
{
    internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Companies)
                .WithOne(x => x.Customer)
                .HasForeignKey(x=>x.CustomerId);

            builder
                .HasMany(x => x.Cases)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

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
