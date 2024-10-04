using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eAccountingServer.Application.Features.CustomerDetails.GetAllCustomerDetails;

internal sealed class GetAllCustomerDetailsQueryHandler(
    ICustomerRepository customerRepository) : IRequestHandler<GetAllCustomerDetailsQuery, Result<Customer>>
{
    public async Task<Result<Customer>> Handle(GetAllCustomerDetailsQuery request, CancellationToken cancellationToken)
    {
        Customer? customer = 
            await customerRepository
            .Where(p => p.Id == request.CustomerId)
            .Include(p=> p.Details)
            .FirstOrDefaultAsync(cancellationToken);

        if(customer is null)
        {
            return Result<Customer>.Failure("Cari bulunamadı");
        }

        return customer;
    }
}
