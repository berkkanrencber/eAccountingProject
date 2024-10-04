using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CustomerDetails.GetAllCustomerDetails;
public sealed record GetAllCustomerDetailsQuery(
    Guid CustomerId) : IRequest<Result<Customer>>;
