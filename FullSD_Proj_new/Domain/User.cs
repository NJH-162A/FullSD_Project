namespace FullSD_Proj_new.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Preferences { get; set; }
    }
}
