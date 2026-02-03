namespace FlatFinder.Api.Models
{
    public class VisitLog
    {
        public string? DeviceModel { get; set; }
        public DateTime Time { get; set; }
        public string? Ip { get; set; }
        public string? UserAgent { get; set; }
        public string? Device { get; set; }
        public string? Browser { get; set; }
        public string? Path { get; set; }
        public string? Referrer { get; set; }
        public string? Screen { get; set; }
        public string? Platform { get; set; }
        public string? DeviceBrand { get; set; }
        public string? Language { get; set; }
    }
}
