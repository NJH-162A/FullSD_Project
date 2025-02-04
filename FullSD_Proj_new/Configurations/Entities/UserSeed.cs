using FullSD_Proj_new.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FullSD_Proj_new.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FullSD_Proj_newUser>
    {
        public void Configure(EntityTypeBuilder<FullSD_Proj_newUser> builder)
        {
            var hasher = new PasswordHasher<FullSD_Proj_newUser>();
            builder.HasData(
            new FullSD_Proj_newUser
            {
                Id = "47722a4e-a2bb-42e7-a36a-00088c112f41",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}