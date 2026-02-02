namespace FlatFinder.Api.Models
{
    public static class CityAliases
    {
        public static readonly Dictionary<string, string> Map = new()
        {
            // ===== HAIFA =====
            { "haifa", "haifa" },
            { "хайфа", "haifa" },
            { "חיפה", "haifa" },

            // ===== TEL AVIV =====
            { "tel aviv", "tel-aviv" },
            { "tel-aviv", "tel-aviv" },
            { "тель авив", "tel-aviv" },
            { "тель-авив", "tel-aviv" },
            { "תל אביב", "tel-aviv" },
            { "תל-אביב", "tel-aviv" },

            // ===== BEER SHEVA =====
            { "beer sheva", "beer-sheva" },
            { "beer-sheva", "beer-sheva" },
            { "беэр шева", "beer-sheva" },
            { "באר שבע", "beer-sheva" },

            // ===== JERUSALEM =====
            { "jerusalem", "jerusalem" },
            { "иерусалим", "jerusalem" },
            { "ירושלים", "jerusalem" }
        };
    }
}
