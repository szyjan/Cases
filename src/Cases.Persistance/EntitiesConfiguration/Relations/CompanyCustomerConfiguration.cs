using Cases.Domain.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Relations
{
    internal sealed class CompanyCustomerConfiguration : IEntityTypeConfiguration<CompanyCustomer>
    {
        public void Configure(EntityTypeBuilder<CompanyCustomer> builder)
        {
            builder.HasKey(x => new { x.CompanyId, x.CustomerId });
        }
    }
}
