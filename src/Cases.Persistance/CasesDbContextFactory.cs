using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cases.Persistance
{
    public class CasesDbContextFactory : IDesignTimeDbContextFactory<CasesDbContext>
    {
        public CasesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CasesDbContext>();
            optionsBuilder.UseSqlServer();

            return new CasesDbContext(optionsBuilder.Options);
        }
    }
}
