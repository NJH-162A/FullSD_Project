using System.Drawing;
using FullSD_Proj_new.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSD_Proj_new.Configurations.Entities
{
    public class TripSeed : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasData(
    new Trip
        {
            Id = 1,
            TripName = "Tokyo Trip",
            Destination = "Tokyo",
            TripStartDate = DateOnly.FromDateTime(DateTime.Now),
            TripEndDate = DateOnly.FromDateTime(DateTime.Now),
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        },
        new Trip
        {
            Id = 2,
            TripName = "Seoul Trip",
            Destination = "Seoul",
            TripStartDate = DateOnly.FromDateTime(DateTime.Now),
            TripEndDate = DateOnly.FromDateTime(DateTime.Now),
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        }
    );

        }
    }
}
