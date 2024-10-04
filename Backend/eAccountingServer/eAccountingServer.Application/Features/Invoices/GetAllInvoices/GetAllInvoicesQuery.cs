using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Invoices.GetAllInvoices;
public sealed record GetAllInvoicesQuery() : IRequest<Result<List<Invoice>>>;
