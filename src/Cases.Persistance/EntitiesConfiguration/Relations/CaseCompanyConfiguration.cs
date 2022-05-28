using Cases.Domain.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Relations
{
    internal sealed class CaseCompanyConfiguration : IEntityTypeConfiguration<CaseCompany>
    {
        public void Configure(EntityTypeBuilder<CaseCompany> builder)
        {
            builder.HasKey(x => new { x.CaseId, x.CompanyId });
        }
    }
}
