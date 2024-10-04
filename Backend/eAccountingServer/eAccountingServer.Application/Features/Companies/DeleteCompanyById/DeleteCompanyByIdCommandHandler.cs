using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.DeleteCompanyById;

internal sealed class DeleteCompanyByIdCommandHandler(
    ICacheService cacheService,
    ICompanyRepository companyRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteCompanyByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteCompanyByIdCommand request, CancellationToken cancellationToken)
    {
        Company company = await companyRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (company is null)
        {
            return Result<string>.Failure("Şirket bulunamadı");
        }

        company.IsDeleted = true;

        await unitOfWork.SaveChangesAsync(cancellationToken);

        cacheService.Remove("companies");

        return "Şirket başarıyla silindi";
    }
}
