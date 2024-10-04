using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.BankDetails.GetAllBankDetails;
public sealed record GetAllBankDetailsQuery(
    Guid BankId,
    DateOnly StartDate,
    DateOnly EndDate) : IRequest<Result<Bank>>;
