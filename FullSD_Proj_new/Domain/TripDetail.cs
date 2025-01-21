namespace FullSD_Proj_new.Domain
{
    public class TripDetail : BaseDomainModel
    {
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
        public string? Desc1 { get; set; }
        public string? Desc2 { get; set; }
        public int TripId { get; set; }
        public string LocationId { get; set; }
        public string TripDetailsTypeId { get; set; }


    }
}
