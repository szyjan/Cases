using Cases.Domain.Entities.Cases;
using Cases.Domain.Entities.ClientData;
using Cases.Domain.Entities.Employees;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cases.Persistance
{
    public class CasesDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CasesDbContext(DbContextOptions<CasesDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {

        }

        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Case> Case { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Deadline> Deadline { get; set; }

        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyIdentifier> CompanyIdentifier { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Employee> Employee { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
