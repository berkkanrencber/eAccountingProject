using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.ProductDetails.GetAllProductDetails;
public sealed record GetAllProductDetailsQuery(
    Guid ProductId) : IRequest<Result<Product>>;
