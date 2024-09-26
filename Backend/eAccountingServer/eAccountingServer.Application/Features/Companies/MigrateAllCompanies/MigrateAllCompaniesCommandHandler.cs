using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.MigrateAllCompanies
{
    internal sealed class MigrateAllCompaniesCommandHandler(
    ICompanyRepository companyRepository,
    ICompanyService companyService) : IRequestHandler<MigrateAllCompaniesCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(MigrateAllCompaniesCommand request, CancellationToken cancellationToken)
        {
            List<Company> companies = await companyRepository.GetAll().ToListAsync(cancellationToken);

            companyService.MigrateAll(companies);

            return "Şirket databaseleri başarıyla güncellendi";
        }
    }
}
