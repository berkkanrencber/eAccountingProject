using eAccountingServer.Application.Features.CustomerDetails.GetAllCustomerDetails;
using eAccountingServer.Application.Features.ProductDetails.GetAllProductDetails;
using eAccountingServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAccountingServer.WebAPI.Controllers;

public sealed class ProductDetailsController : ApiController
{
    public ProductDetailsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllProductDetailsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
