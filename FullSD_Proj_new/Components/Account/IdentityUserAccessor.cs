using FullSD_Proj_new.Data;
using Microsoft.AspNetCore.Identity;

namespace FullSD_Proj_new.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FullSD_Proj_newUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FullSD_Proj_newUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
