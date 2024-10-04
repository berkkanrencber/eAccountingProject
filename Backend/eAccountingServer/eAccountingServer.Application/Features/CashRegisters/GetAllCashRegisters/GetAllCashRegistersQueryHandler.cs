using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.GetAllCashRegisters;

internal sealed class GetAllCashRegistersQueryHandler(
    ICashRegisterRepository cashRegisterRepository,
    ICacheService cacheService) : IRequestHandler<GetAllCashRegistersQuery, Result<List<CashRegister>>>
{
    public async Task<Result<List<CashRegister>>> Handle(GetAllCashRegistersQuery request, CancellationToken cancellationToken)
    {
        List<CashRegister>? cashRegisters;

        cashRegisters = cacheService.Get<List<CashRegister>>("cashRegisters");

        if(cashRegisters is null)
        {
            cashRegisters =
            await cashRegisterRepository
            .GetAll().OrderBy(p => p.Name)
            .ToListAsync(cancellationToken);

            cacheService.Set<List<CashRegister>>("cashRegisters", cashRegisters);
        }
        

        return cashRegisters;
    }
}
