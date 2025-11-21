using Catalog.Domain.AggregatesModel.ProductAggregate;

using Microsoft.EntityFrameworkCore;

using Moser.BuildingBlocks.Infrastructure.Persistence;

namespace Catalog.Infrastructure;

internal class CatalogDbContext : DbContextBase
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogDbContext).Assembly);
    }
}
