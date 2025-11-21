using Anima.Blueprint.BuildingBlocks.Infrastructure.Persistence;

namespace Anima.Blueprint.Catalog.Infrastructure;

internal class UnitOfWork : UnitOfWorkBase<CatalogDbContext>
{
    public UnitOfWork(CatalogDbContext context) : base(context) { }
}
