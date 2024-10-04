﻿using eAccountingServer.Application.Features.Reports.ProductProfitabilityReports;
using eAccountingServer.Application.Features.Reports.PurchaseReports;
using eAccountingServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAccountingServer.WebAPI.Controllers;

public sealed class ReportsController : ApiController
{
    public ReportsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> ProductProfitabilityReports(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new ProductProfitabilityReportsQuery(), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet]
    public async Task<IActionResult> PurchaseReports(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new PurchaseReportsQuery(), cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
