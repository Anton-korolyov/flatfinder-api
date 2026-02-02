using System.Text.RegularExpressions;
using FlatFinder.Api.Models;

namespace FlatFinder.Api.Services
{
    public class SearchParserService
    {
     
            public SearchResult Parse(string text)
            {
                var originalText = text;
                text = text.ToLower();

                var result = new SearchResult();

                // =====================
                // 📍 ГОРОД (любой язык)
                // =====================
                foreach (var alias in CityAliases.Map.Keys)
                {
                    if (text.Contains(alias))
                    {
                        result.City = alias; // НЕ канон!
                        break;
                    }
                }

                // =====================
                // 🛏 КОМНАТЫ
                // =====================
                var roomsMatch = Regex.Match(text, @"(\d)\s*(комн|комнаты|комната|חדרים?|rooms?)");
                if (roomsMatch.Success)
                    result.Rooms = int.Parse(roomsMatch.Groups[1].Value);

                // =====================
                // 💰 ЦЕНА
                // =====================
                var priceMatch = Regex.Match(text, @"(до|עד|up to)\s*(\d{3,5})");
                if (priceMatch.Success)
                    result.PriceTo = int.Parse(priceMatch.Groups[2].Value);

                // =====================
                // 🚫 БЕЗ МАКЛЕРА
                // =====================
                if (
                    text.Contains("без маклер") ||
                    text.Contains("без агента") ||
                    text.Contains("ללא תיווך") ||
                    text.Contains("no agent")
                )
                {
                    result.WithoutAgent = true;
                }

                return result;
            }
        }
    
}
