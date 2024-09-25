using AutoMapper;
using eAccountingServer.Application.Users.CreateUser;
using eAccountingServer.Application.Users.UpdateUser;
using eAccountingServer.Domain.Entities;

namespace eAccountingServer.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserCommand, AppUser>();
            CreateMap<UpdateUserCommand, AppUser>();
        }
    }
}
