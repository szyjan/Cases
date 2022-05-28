using Cases.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cases.Persistance.EntitiesConfiguration.Employees
{
    internal sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Supervisor)
                .WithMany()
                .IsRequired(required: false);

            //Change trackable stuff
            builder
                .HasOne(x => x.CreatedByEmployee)
                .WithMany()
                .HasForeignKey(x => x.CreatedBy);

            builder
                .HasOne(x => x.ModifiedByEmployee)
                .WithMany()
                .HasForeignKey(x => x.ModifiedBy);

            //Initial seed
            builder
                .HasData(new Employee()
                {
                    Id = 1,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    EmailAddress = "szymon.jankowski@hotmail.com",
                    IsCourtAvailable = false,
                    FirstName = "Szymon",
                    LastName = "Jankowski",
                    CreatedDateUtc = DateTime.UtcNow,
                    ModifiedDateUtc = DateTime.UtcNow
                });
        }
    }
}
