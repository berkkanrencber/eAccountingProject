using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Customers.CreateCustomer;
public sealed record CreateCustomerCommand(
    string Name,
    int TypeValue,
    string City,
    string Town,
    string FullAddress,
    string TaxDepartment,
    string TaxNumber
    ) : IRequest<Result<string>>;
