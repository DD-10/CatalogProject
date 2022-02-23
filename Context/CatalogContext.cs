using Microsoft.EntityFrameworkCore;

namespace Catalog.Context
{
    public class CatalogContext : DbContext
    {
         public CatalogContext (DbContextOptions<CatalogContext> options)
            : base(options)
        {
        }

        public DbSet<Catalog.Entities.Item>Item { get; set; }
    }
}