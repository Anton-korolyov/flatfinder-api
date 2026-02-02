namespace FlatFinder.Api.Models
{
    public class SearchResult
    {
        public string? City { get; set; }
        public int? Rooms { get; set; }
        public int? PriceTo { get; set; }
        public bool WithoutAgent { get; set; }

        public List<SearchLink> Links { get; set; } = new();
    }
}
