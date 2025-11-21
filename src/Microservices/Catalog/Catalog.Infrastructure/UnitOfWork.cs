using Moser.BuildingBlocks.Infrastructure.Persistence;

namespace Catalog.Infrastructure;

internal class UnitOfWork : UnitOfWorkBase<CatalogDbContext>
{
    public UnitOfWork(CatalogDbContext context) : base(context) { }
}
