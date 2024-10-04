using eAccountingServer.Domain.Enums;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.CreateCashRegister;
public sealed record CreateCashRegisterCommand(
    string Name,
    int CurrencyTypeValue) : IRequest<Result<string>>;
