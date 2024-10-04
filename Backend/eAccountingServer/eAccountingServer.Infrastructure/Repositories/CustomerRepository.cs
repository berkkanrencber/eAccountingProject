using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using eAccountingServer.Infrastructure.Context;
using GenericRepository;

namespace eAccountingServer.Infrastructure.Repositories;
internal sealed class CustomerRepository : Repository<Customer, CompanyDbContext>, ICustomerRepository
{
    public CustomerRepository(CompanyDbContext context) : base(context)
    {
    }
}
