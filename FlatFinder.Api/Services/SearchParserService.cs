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

            // 📍 Хайфа — пока один город
            if (
                text.Contains("хайф") ||
                text.Contains("haifa") ||
                text.Contains("חיפה")
            )
            {
                result.City = "haifa";
            }

            // 🛏 комнаты
            var roomsMatch = Regex.Match(text, @"(\d)\s*(комн|комнаты|комната)");
            if (roomsMatch.Success)
                result.Rooms = int.Parse(roomsMatch.Groups[1].Value);

            // 💰 цена
            var priceMatch = Regex.Match(text, @"до\s*(\d{3,5})");
            if (priceMatch.Success)
                result.PriceTo = int.Parse(priceMatch.Groups[1].Value);

            // 🚫 без маклера
            if (
                text.Contains("без маклер") ||
                text.Contains("без агента")
            )
            {
                result.WithoutAgent = true;
            }

            return result;
        }
    }
}
