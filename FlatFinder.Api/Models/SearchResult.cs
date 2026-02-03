namespace FlatFinder.Api.Models
{
    public class SearchResult
    {
        public SearchType Type { get; set; } = SearchType.Rent;
        public string? City { get; set; }
        public int? Rooms { get; set; }
        public int? PriceTo { get; set; }
        public bool WithoutAgent { get; set; }
        // 🔽 для машин (позже)
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public List<SearchLink> Links { get; set; } = new();
    }
}
