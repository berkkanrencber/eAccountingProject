using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Products.GetAllProducts;
public sealed record GetAllProductsQuery() : IRequest<Result<List<Product>>>;
