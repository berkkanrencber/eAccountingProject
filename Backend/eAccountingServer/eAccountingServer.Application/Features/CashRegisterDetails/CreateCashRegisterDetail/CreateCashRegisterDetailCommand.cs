﻿using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisterDetails.CreateCashRegisterDetail;
public sealed record CreateCashRegisterDetailCommand(
    Guid CashRegisterId,
    DateOnly Date,
    int Type,
    decimal Amount,
    Guid? OppositeCashRegisterId,
    Guid? OppositeBankId,
    Guid? OppositeCustomerId,
    decimal OppositeAmount,
    string Description
    ) : IRequest<Result<string>>;
