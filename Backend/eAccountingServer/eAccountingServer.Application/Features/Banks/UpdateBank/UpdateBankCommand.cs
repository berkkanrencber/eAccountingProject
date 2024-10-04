﻿using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Banks.UpdateBank;
public sealed record UpdateBankCommand(
    Guid Id,
    string Name,
    string IBAN,
    int CurrencyTypeValue) : IRequest<Result<string>>;
