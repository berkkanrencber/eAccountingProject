﻿using AutoMapper;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Products.DeleteProductById;
public sealed record DeleteProductByIdCommand(
    Guid Id) : IRequest<Result<string>>;
