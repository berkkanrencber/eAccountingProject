using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eAccountingServer.Application.Features.Customers.GetAllCustomers;

internal sealed class GetAllCustomersQueryHandler(
    ICustomerRepository customerRepository,
    ICacheService cacheService) : IRequestHandler<GetAllCustomersQuery, Result<List<Customer>>>
{
    public async Task<Result<List<Customer>>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        List<Customer>? customers = cacheService.Get<List<Customer>>("customers");

        if(customers is null)
        {
            customers = 
                await customerRepository
                .GetAll()
                .OrderBy(p => p.Name)
                .ToListAsync(cancellationToken);

            cacheService.Set("customers", customers);
        }

        return customers;
    }
}
