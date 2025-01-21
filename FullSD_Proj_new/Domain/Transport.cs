namespace FullSD_Proj_new.Domain
{
    public class Transport : BaseDomainModel

    {
        public DateOnly? Date { get; set; }
        public TimeOnly? DepartureTime { get; set; }
        public TimeOnly? ArrivalTime { get; set; }
        public string? Type { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? BookingRef { get; set; }
        public int TripId { get; set; }
    }
}
