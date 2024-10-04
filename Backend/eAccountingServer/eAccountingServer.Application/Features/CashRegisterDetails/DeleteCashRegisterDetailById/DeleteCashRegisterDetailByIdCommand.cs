using FluentValidation;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisterDetails.DeleteCashRegisterDetailById;
public sealed record DeleteCashRegisterDetailByIdCommand(
    Guid Id) : IRequest<Result<string>>;
