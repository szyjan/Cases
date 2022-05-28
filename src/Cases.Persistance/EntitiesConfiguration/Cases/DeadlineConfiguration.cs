using Cases.Domain.Entities.Cases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Cases
{
    internal sealed class DeadlineConfiguration : IEntityTypeConfiguration<Deadline>
    {
        public void Configure(EntityTypeBuilder<Deadline> builder)
        {
            builder.HasKey(x => x.Id);

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
