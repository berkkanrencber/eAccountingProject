using eAccountingServer.Application.Features.Banks.CreateBank;
using eAccountingServer.Application.Features.Banks.DeleteBankById;
using eAccountingServer.Application.Features.Banks.GetAllBanks;
using eAccountingServer.Application.Features.Banks.UpdateBank;
using eAccountingServer.Application.Features.Users.CreateUser;
using eAccountingServer.Application.Features.Users.DeleteUserById;
using eAccountingServer.Application.Features.Users.GetAllUsers;
using eAccountingServer.Application.Features.Users.UpdateUser;
using eAccountingServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAccountingServer.WebAPI.Controllers;

public sealed class BanksController : ApiController
{
    public BanksController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllBanksQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBankCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateBankCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteBankByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
