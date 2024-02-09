using Microsoft.AspNetCore.Authorization;

namespace Gatherly.Infrastructure.Authentication;
public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(Domain.Enums.Permission permission)
        : base(policy: permission.ToString())
    {

    }
}
