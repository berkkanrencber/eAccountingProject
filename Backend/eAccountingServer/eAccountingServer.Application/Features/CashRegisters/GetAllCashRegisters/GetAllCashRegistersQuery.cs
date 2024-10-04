using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.GetAllCashRegisters;
public sealed record GetAllCashRegistersQuery() : IRequest<Result<List<CashRegister>>>;
