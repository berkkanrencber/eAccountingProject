﻿using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.DeleteCashRegisterById;
public sealed record DeleteCashRegisterByIdCommand(
    Guid Id) : IRequest<Result<string>>;
