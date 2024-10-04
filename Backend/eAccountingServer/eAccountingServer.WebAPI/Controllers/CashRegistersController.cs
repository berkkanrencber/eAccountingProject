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

public sealed class CashRegistersController : ApiController
{
    public CashRegistersController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllCashRegistersQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCashRegisterCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateCashRegisterCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteCashRegisterByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
