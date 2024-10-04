using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisterDetails.GetAllCashRegisterDetails;
public sealed record GetAllCashRegisterDetailsQuery(
    Guid CashRegisterId,
    DateOnly StartDate,
    DateOnly EndDate): IRequest<Result<CashRegister>>;
