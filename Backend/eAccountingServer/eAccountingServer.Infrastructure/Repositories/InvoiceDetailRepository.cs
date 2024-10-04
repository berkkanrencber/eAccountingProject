using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using eAccountingServer.Infrastructure.Context;
using GenericRepository;

namespace eAccountingServer.Infrastructure.Repositories;

internal sealed class InvoiceDetailRepository : Repository<InvoiceDetail, CompanyDbContext>, IInvoiceDetailRepository
{
    public InvoiceDetailRepository(CompanyDbContext context) : base(context)
    {
    }
}