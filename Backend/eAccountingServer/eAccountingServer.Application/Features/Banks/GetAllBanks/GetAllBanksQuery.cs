using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Banks.GetAllBanks;
public sealed record GetAllBanksQuery(): IRequest<Result<List<Bank>>>;
