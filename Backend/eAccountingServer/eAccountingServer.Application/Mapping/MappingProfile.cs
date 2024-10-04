using AutoMapper;
using eAccountingServer.Application.Features.CashRegisters.CreateCashRegister;
using eAccountingServer.Application.Features.CashRegisters.UpdateCashRegister;
using eAccountingServer.Application.Features.Companies.CreateCompany;
using eAccountingServer.Application.Features.Companies.UpdateCompany;
using eAccountingServer.Application.Features.Users.CreateUser;
using eAccountingServer.Application.Features.Users.UpdateUser;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Enums;
using eAccountingServer.Application.Features.Banks.CreateBank;
using eAccountingServer.Application.Features.Banks.UpdateBank;
using eAccountingServer.Application.Features.Customers.CreateCustomer;
using eAccountingServer.Application.Features.Customers.UpdateCustomer;
using eAccountingServer.Application.Features.Invoices.CreateInvoice;
using eAccountingServer.Application.Features.Products.CreateProduct;
using eAccountingServer.Application.Features.Products.UpdateProduct;
using MediatR;

namespace eAccountingServer.Application.Mapping;
public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserCommand, AppUser>();
        CreateMap<UpdateUserCommand, AppUser>();

        CreateMap<CreateCompanyCommand, Company>();
        CreateMap<UpdateCompanyCommand, Company>();

        CreateMap<CreateCashRegisterCommand, CashRegister>().ForMember(member => member.CurrencyType, options =>
        {
            options.MapFrom(map => CurrencyTypeEnum.FromValue(map.CurrencyTypeValue));
        });
        CreateMap<UpdateCashRegisterCommand, CashRegister>().ForMember(member => member.CurrencyType, options =>
        {
            options.MapFrom(map => CurrencyTypeEnum.FromValue(map.CurrencyTypeValue));
        });

        CreateMap<CreateBankCommand, Bank>().ForMember(member => member.CurrencyType, options =>
        {
            options.MapFrom(map => CurrencyTypeEnum.FromValue(map.CurrencyTypeValue));
        });
        CreateMap<UpdateBankCommand, Bank>().ForMember(member => member.CurrencyType, options =>
        {
            options.MapFrom(map => CurrencyTypeEnum.FromValue(map.CurrencyTypeValue));
        });

        CreateMap<CreateCustomerCommand, Customer>().ForMember(member => member.Type, options =>
        {
            options.MapFrom(map => CustomerTypeEnum.FromValue(map.TypeValue));
        });
        CreateMap<UpdateCustomerCommand, Customer>().ForMember(member => member.Type, options =>
        {
            options.MapFrom(map => CustomerTypeEnum.FromValue(map.TypeValue));
        });

        CreateMap<CreateProductCommand, Product>();
        CreateMap<UpdateProductCommand, Product>();

        CreateMap<CreateInvoiceCommand, Invoice>()
            .ForMember(member => member.Type, options =>
            {
                options.MapFrom(map => InvoiceTypeEnum.FromValue(map.TypeValue));
            })
            .ForMember(member => member.Details, options =>
            {
                options.MapFrom(map => map.Details.Select(s => new InvoiceDetail()
                {
                    ProductId = s.ProductId,
                    Quantity = s.Quantity,
                    Price = s.Price
                }).ToList());
            })
            .ForMember(member => member.Amount, options =>
            {
                options.MapFrom(map => map.Details.Sum(s => s.Quantity * s.Price));
            });
    }
}
