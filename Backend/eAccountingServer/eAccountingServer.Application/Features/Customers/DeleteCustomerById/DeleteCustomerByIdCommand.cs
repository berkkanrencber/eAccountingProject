using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Customers.DeleteCustomerById;
public sealed record DeleteCustomerByIdCommand(
    Guid Id): IRequest<Result<string>>;
