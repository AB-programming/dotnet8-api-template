using Dotnet8ApiTemplate.Models;
using Microsoft.AspNetCore.Identity;

namespace Dotnet8ApiTemplate.Services;

public class AppUserEmailSender : IEmailSender<AppUser>
{
    public Task SendConfirmationLinkAsync(AppUser user, string email, string confirmationLink)
    {
        return Task.CompletedTask;
    }

    public Task SendPasswordResetLinkAsync(AppUser user, string email, string resetLink)
    {
        return Task.CompletedTask;
    }

    public Task SendPasswordResetCodeAsync(AppUser user, string email, string resetCode)
    {
        return Task.CompletedTask;
    }
}
