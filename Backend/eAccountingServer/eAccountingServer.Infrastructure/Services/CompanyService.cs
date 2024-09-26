using eAccountingServer.Application.Services;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAccountingServer.Infrastructure.Services
{
    internal sealed class CompanyService : ICompanyService
    {
        public void MigrateAll(List<Company> companies)
        {
            foreach (var company in companies)
            {
                CompanyDbContext context = new(company);

                context.Database.Migrate();
            }
        }
    }
}
