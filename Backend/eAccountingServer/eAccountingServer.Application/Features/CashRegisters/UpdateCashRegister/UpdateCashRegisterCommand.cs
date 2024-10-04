using eAccountingServer.Domain.Enums;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.UpdateCashRegister;
public sealed record UpdateCashRegisterCommand(
    Guid Id,
    string Name,
    int CurrencyTypeValue) : IRequest<Result<string>>;
