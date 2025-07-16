using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Seguroquesi.Data;

namespace Seguroquesi.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=Seguroquesi.db"); // ⚠️ conexión de desarrollo

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
