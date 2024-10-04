using AutoMapper;
using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.CashRegisters.CreateCashRegister;

internal sealed class CreateCashRegisterCommandHandler(
    ICashRegisterRepository cashRegisterRepository,
    IUnitOfWorkCompany unitOfWorkCompany,
    IMapper mapper,
    ICacheService cacheService) : IRequestHandler<CreateCashRegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCashRegisterCommand request, CancellationToken cancellationToken)
    {
        bool isNameExists = await cashRegisterRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

        if (isNameExists)
        {
            return Result<string>.Failure("Bu kasa adı daha önce kullanılmış");
        }

        CashRegister cashRegister = mapper.Map<CashRegister>(request);

        await cashRegisterRepository.AddAsync(cashRegister);
        await unitOfWorkCompany.SaveChangesAsync(cancellationToken);

        cacheService.Remove("cashRegisters");

        return "Kasa kaydı başarıyla tamamlandı";
    }
}
