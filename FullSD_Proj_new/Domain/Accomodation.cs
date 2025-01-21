namespace FullSD_Proj_new.Domain
{
    public class Accomodation : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

        public DateOnly? InDate { get; set; }
        public DateOnly? OutDate { get; set; }
        public string? BookingRef { get; set; }
        public string? ContactInfo { get; set; }

        public int TripId { get; set; }
    }
}