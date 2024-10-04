using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Reports.PurchaseReports;
public sealed record PurchaseReportsQuery(): IRequest<Result<object>>;
