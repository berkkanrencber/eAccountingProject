using eAccountingServer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.GetAllCompanies
{
    public sealed record GetAllCompaniesQuery() :IRequest<Result<List<Company>>>;
}
