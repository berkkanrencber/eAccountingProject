using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.BankDetails.UpdateBankDetail;
public sealed record UpdateBankDetailCommand(
    Guid Id,
    Guid BankId,
    int Type,
    DateOnly Date,
    decimal Amount,
    string Description) : IRequest<Result<string>>;
