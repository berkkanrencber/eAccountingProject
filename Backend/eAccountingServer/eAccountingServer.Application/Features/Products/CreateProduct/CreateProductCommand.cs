using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name) : IRequest<Result<string>>;
