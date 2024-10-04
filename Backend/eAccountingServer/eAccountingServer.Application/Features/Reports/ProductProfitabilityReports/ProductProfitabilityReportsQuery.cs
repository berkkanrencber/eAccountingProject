using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Reports.ProductProfitabilityReports;
public sealed record ProductProfitabilityReportsQuery() : IRequest<Result<List<ProductProfitabilityReportsQueryResponse>>>;
