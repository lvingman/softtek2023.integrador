using Microsoft.EntityFrameworkCore;

namespace TechOil.DataAccess.Seeders
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}

