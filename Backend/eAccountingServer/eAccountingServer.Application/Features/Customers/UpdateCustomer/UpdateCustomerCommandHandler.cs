﻿using AutoMapper;
using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Customers.UpdateCustomer;

internal sealed class UpdateCustomerCommandHandler(
    ICustomerRepository customerRepository,
    IUnitOfWorkCompany unitOfWorkCompany,
    IMapper mapper,
    ICacheService cacheService) : IRequestHandler<UpdateCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await customerRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if(customer is null)
        {
            return Result<string>.Failure("Cari bulunamadı");
        }

        mapper.Map(request, customer);

        await unitOfWorkCompany.SaveChangesAsync(cancellationToken);

        cacheService.Remove("customers");

        return "Cari başarıyla güncellendi";
    }
}
