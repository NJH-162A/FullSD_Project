using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;
namespace CarRentalManagement.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "4202b272-8cb3-40a0-a772-e6bba22a4d11",
                Name = "Kai",
                NormalizedName = "KAI"
            },
            new IdentityRole
            {
                Id = "cbadd9b2-c36e-4467-9c23-f54114d747ad",
                Name = "JiaHui",
                NormalizedName = "JIAHUI"
            },
            new IdentityRole
            {
                Id = "95724959-75eb-4d7c-927e-1dbc798f2093",
                Name = "Admin",
                NormalizedName = "ADMIN"
            }
            );

        }
    }
}

