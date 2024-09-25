using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace eAccountingServer.Application.Features.Auth.ConfirmEmail;

public sealed record ConfirmEmailCommand(
    string Email) : IRequest<Result<string>>;
