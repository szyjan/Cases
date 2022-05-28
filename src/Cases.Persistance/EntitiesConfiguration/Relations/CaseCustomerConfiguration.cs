using Cases.Domain.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Relations
{
    internal sealed class CaseCustomerConfiguration : IEntityTypeConfiguration<CaseCustomer>
    {
        public void Configure(EntityTypeBuilder<CaseCustomer> builder)
        {
            builder.HasKey(x => new { x.CaseId, x.CustomerId });
        }
    }
}
