using Domain.Abstractions.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.Extensions.Attributes;

public class AuthorizedAttribute : TypeFilterAttribute
{
    public AuthorizedAttribute(bool administrator=false) : base(typeof(AuthorizedFilter))
    {
        Arguments = new object[] {administrator};
    }
}

public class AuthorizedFilter : IAsyncAuthorizationFilter
{
    private readonly IAuthenticateService _authenticateService;
    private readonly bool _administrator;
    

    public AuthorizedFilter(bool administrator, IAuthenticateService authenticateService)
    {
        _administrator = administrator;
        _authenticateService = authenticateService;
    }

    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        if (_administrator)
        {
            var userModel = await _authenticateService.GetUser(context.HttpContext.User);
            if (userModel == null || !userModel.Administrator)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}