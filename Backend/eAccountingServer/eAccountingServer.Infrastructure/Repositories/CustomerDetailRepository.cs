using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using eAccountingServer.Infrastructure.Context;
using GenericRepository;

namespace eAccountingServer.Infrastructure.Repositories;
internal sealed class CustomerDetailRepository : Repository<CustomerDetail, CompanyDbContext>, ICustomerDetailRepository
{
    public CustomerDetailRepository(CompanyDbContext context) : base(context)
    {
    }
}
