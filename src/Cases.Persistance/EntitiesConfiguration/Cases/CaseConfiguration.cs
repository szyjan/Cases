using Cases.Domain.Entities.Cases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Cases
{
    internal sealed class CaseConfiguration : IEntityTypeConfiguration<Case>
    {
        public void Configure(EntityTypeBuilder<Case> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Customers)
                .WithOne(x => x.Case)
                .HasForeignKey(x => x.CaseId);

            builder
                .HasMany(x => x.Companies)
                .WithOne(x => x.Case)
                .HasForeignKey(x => x.CaseId);

            builder
                .HasMany(x => x.CaseWorkers)
                .WithOne(x => x.Case);

            builder
                .HasMany(x => x.Deadlines)
                .WithOne()
                .HasForeignKey(x => x.CaseId);

            builder
                .HasMany(x => x.Attachemnts)
                .WithOne()
                .HasForeignKey(x => x.CaseId);

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
