using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using eAccountingServer.Infrastructure.Context;
using GenericRepository;

namespace eAccountingServer.Infrastructure.Repositories;
internal sealed class ProductDetailRepsitory : Repository<ProductDetail, CompanyDbContext>, IProductDetailRepository
{
    public ProductDetailRepsitory(CompanyDbContext context) : base(context)
    {
    }
}
