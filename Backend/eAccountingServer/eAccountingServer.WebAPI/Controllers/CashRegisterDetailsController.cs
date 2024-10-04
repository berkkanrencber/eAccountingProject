using eAccountingServer.Application.Features.CashRegisterDetails.CreateCashRegisterDetail;
using eAccountingServer.Application.Features.CashRegisterDetails.DeleteCashRegisterDetailById;
using eAccountingServer.Application.Features.CashRegisterDetails.GetAllCashRegisterDetails;
using eAccountingServer.Application.Features.CashRegisterDetails.UpdateCashRegisterDetail;
using eAccountingServer.Application.Features.CashRegisters.CreateCashRegister;
using eAccountingServer.Application.Features.CashRegisters.DeleteCashRegisterById;
using eAccountingServer.Application.Features.CashRegisters.GetAllCashRegisters;
using eAccountingServer.Application.Features.CashRegisters.UpdateCashRegister;
using eAccountingServer.Application.Features.Users.CreateUser;
using eAccountingServer.Application.Features.Users.DeleteUserById;
using eAccountingServer.Application.Features.Users.GetAllUsers;
using eAccountingServer.Application.Features.Users.UpdateUser;
using eAccountingServer.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eAccountingServer.WebAPI.Controllers;

public sealed class CashRegisterDetailsController : ApiController
{
    public CashRegisterDetailsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCashRegisterDetailsQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCashRegisterDetailCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCashRegisterDetailCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteCashRegisterDetailByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
