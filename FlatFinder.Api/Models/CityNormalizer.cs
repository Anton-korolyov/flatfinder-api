namespace FlatFinder.Api.Models
{
    public static class CityNormalizer
    {
        public static string? Normalize(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            var key = input.Trim().ToLower();

            return CityAliases.Map.TryGetValue(key, out var canonical)
                ? canonical
                : null;
        }
    }
}
