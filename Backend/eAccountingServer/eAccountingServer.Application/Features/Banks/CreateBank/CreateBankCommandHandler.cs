﻿using AutoMapper;
using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Banks.CreateBank;

internal sealed class CreateBankCommandHandler(
    IBankRepository bankRepository,
    IUnitOfWorkCompany unitOfWorkCompany,
    IMapper mapper,
    ICacheService cacheService) : IRequestHandler<CreateBankCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateBankCommand request, CancellationToken cancellationToken)
    {
        bool isIBANExists = await bankRepository.AnyAsync(p => p.IBAN == request.IBAN, cancellationToken);
        if(isIBANExists)
        {
            return Result<string>.Failure("IBAN daha önce kaydedilmiş");
        }

        Bank bank = mapper.Map<Bank>(request);

        await bankRepository.AddAsync(bank, cancellationToken);
        await unitOfWorkCompany.SaveChangesAsync(cancellationToken);

        cacheService.Remove("banks");

        return "Banka başarıyla kaydedili";
    }
}
