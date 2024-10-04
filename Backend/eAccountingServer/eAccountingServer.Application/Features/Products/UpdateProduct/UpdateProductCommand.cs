using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Products.UpdateProduct;
public sealed record UpdateProductCommand(
    Guid Id,
    string Name) : IRequest<Result<string>>;
