﻿using eAccountingServer.Domain.Entities;
using FluentEmail.Core;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eAccountingServer.Domain.Events;

public sealed class SendConfirmEmailEvent(
    UserManager<AppUser> userManager,
    IFluentEmail fluentEmail) : INotificationHandler<AppUserEvent>
{
    public async Task Handle(AppUserEvent notification, CancellationToken cancellationToken)
    {
        AppUser? appUser = await userManager.FindByIdAsync(notification.UserId.ToString());

        if(appUser is not null)
        {
            await fluentEmail
                .To(appUser.Email)
                .Subject("Mail Onayı")
                .Body(CreateBody(appUser),true)
                .SendAsync(cancellationToken);
        }
    }

    public string CreateBody(AppUser appUser)
    {
        string body = $@"Mail adresinizi onlamak için aşağıdaki linke tıklayın.<a href='http://localhost:4200/confirm-email/{appUser.Email}' target = '_blank'>Maili Onaylamak için tıklayın.</a>";
        return body;
    }
}
