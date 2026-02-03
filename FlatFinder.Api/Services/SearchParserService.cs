using System.Text.RegularExpressions;
using FlatFinder.Api.Models;

namespace FlatFinder.Api.Services
{
    public class SearchParserService
    {

        public SearchResult Parse(string text)
        {
            text = text.ToLower();
            var result = new SearchResult();

            DetectSearchType(text, result);

            // 📍 ГОРОД
            foreach (var pair in CityAliases.Map)
            {
                if (text.Contains(pair.Key))
                {
                    result.City = pair.Value;
                    break;
                }
            }
            // =====================
            // 🌍 РЕГИОН
            // =====================
            foreach (var pair in RegionMap.Map)
            {
                if (text.Contains(pair.Key))
                {
                    result.Region = pair.Value;
                    break;
                }
            }
            // 🛏 КОМНАТЫ
            var roomsMatch = Regex.Match(text, @"(\d)\s*(комн|комнаты|комната|חדרים?|rooms?)");
            if (roomsMatch.Success)
                result.Rooms = int.Parse(roomsMatch.Groups[1].Value);

            // 💰 ЦЕНА
            var priceMatch = Regex.Match(text, @"(до|עד|up to)\s*([\d,]{3,7})");
            if (priceMatch.Success)
            {
                var raw = priceMatch.Groups[2].Value.Replace(",", "");
                result.PriceTo = int.Parse(raw);
            }

            // 🚫 БЕЗ МАКЛЕРА
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
        private static void DetectSearchType(string text, SearchResult result)
        {
            if (
                text.Contains("маш") ||
                text.Contains("авто") ||
                text.Contains("car") ||
                text.Contains("vehicle") ||
                text.Contains("רכב")
            )
            {
                result.Type = SearchType.Cars;
            }
        }
    }

}
