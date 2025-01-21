namespace FullSD_Proj_new.Domain
{
    public class Trip : BaseDomainModel
    {
        public string? TripName { get; set; }
        public string? Destination { get; set; }
        public DateOnly TripStartDate { get; set; }
        public DateOnly TripEndDate { get; set; }
        public string UserId { get; set; }
    }
}
