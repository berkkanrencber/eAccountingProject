using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Enums;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Customers.GetAllCustomers;
public sealed record GetAllCustomersQuery() : IRequest<Result<List<Customer>>>;
