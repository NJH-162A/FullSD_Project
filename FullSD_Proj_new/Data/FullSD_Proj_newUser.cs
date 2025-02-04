using Microsoft.AspNetCore.Identity;

namespace FullSD_Proj_new.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FullSD_Proj_newUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
