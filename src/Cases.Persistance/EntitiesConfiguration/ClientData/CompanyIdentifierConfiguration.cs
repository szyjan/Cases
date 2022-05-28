using Cases.Domain.Entities.ClientData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.ClientData
{
    internal sealed class CompanyIdentifierConfiguration : IEntityTypeConfiguration<CompanyIdentifier>
    {
        public void Configure(EntityTypeBuilder<CompanyIdentifier> builder)
        {
            builder.HasKey(x => x.Identifier);

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
