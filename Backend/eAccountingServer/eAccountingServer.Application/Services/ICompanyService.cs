using eAccountingServer.Domain.Entities;

namespace eAccountingServer.Application.Services
{
    public interface ICompanyService
    {
        void MigrateAll(List<Company> companies);
    }
}
