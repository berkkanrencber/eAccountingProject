using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.MigrateAllCompanies;
public sealed record MigrateAllCompaniesCommand() : IRequest<Result<string>>;
