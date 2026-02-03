namespace FlatFinder.Api.Models
{
    public class TrackRequest
    {
        public string? Path { get; set; }
        public string? Referrer { get; set; }   // ✅ nullable
        public string? Screen { get; set; }
        public string? Language { get; set; }
    }
}
