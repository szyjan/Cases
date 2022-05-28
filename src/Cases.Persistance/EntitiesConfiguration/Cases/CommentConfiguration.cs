using Cases.Domain.Entities.Cases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Cases
{
    internal sealed class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
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
