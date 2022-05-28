using Cases.Domain.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Relations
{
    internal sealed class CaseEmployeeConfiguration : IEntityTypeConfiguration<CaseEmployee>
    {
        public void Configure(EntityTypeBuilder<CaseEmployee> builder)
        {
            builder.HasKey(x => new { x.CaseId, x.EmployeeId });
        }
    }
}
