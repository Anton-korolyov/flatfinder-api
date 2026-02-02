using FlatFinder.Api.Models;

namespace FlatFinder.Api.Services
{
    public class SearchLinkBuilder
    {
        public List<SearchLink> Build(SearchResult data)
        {
            var links = new List<SearchLink>();

            var city = data.City?.Trim().ToLower();

            // =====================
            // 🟧 YAD2
            // =====================
            if (!string.IsNullOrEmpty(city) && CityMap.Yad2.TryGetValue(city, out var cityCode))
            {
                var yad2 = $"https://www.yad2.co.il/realestate/rent?city={cityCode}";

                if (data.PriceTo != null)
                    yad2 += $"&price=0-{data.PriceTo}";

                if (data.Rooms != null)
                    yad2 += $"&rooms={data.Rooms}-{data.Rooms}";

                if (data.WithoutAgent)
                    yad2 += "&fromAgent=0";

                links.Add(new SearchLink
                {
                    Site = "Yad2",
                    Url = yad2,
                    Description = "Главный сайт объявлений"
                });
            }

            // =====================
            // 🟨 HOMELESS
            // =====================
            if (!string.IsNullOrEmpty(city) &&
       CityMap.HomelessRegionMap.TryGetValue(city, out var regionId))
            {
                var parts = new List<string>
    {
        $"inumber1={regionId}"
    };

                if (data.Rooms != null)
                    parts.Add($"inumber4_1={data.Rooms}");

                if (data.PriceTo != null)
                    parts.Add($"flong3_1={data.PriceTo}");

                var homelessUrl =
                    "https://www.homeless.co.il/rent/" + string.Join("$$", parts);

                links.Add(new SearchLink
                {
                    Site = "Homeless",
                    Url = homelessUrl,
                    Description = "Частные объявления без маклеров"
                });
            }
            else
            {
                links.Add(new SearchLink
                {
                    Site = "Homeless",
                    Url = "https://www.homeless.co.il/rent",
                    Description = "Частные объявления без маклеров"
                });
            }


            // =====================
            // 🟩 MADLAN (✔ правильно)
            // =====================
            if (!string.IsNullOrEmpty(city) &&
            CityMap.Madlan.TryGetValue(city, out var madlanSlug))
            {
                var madlanUrl =
                    $"https://www.madlan.co.il/for-rent/{madlanSlug}";

                // 💰 фильтр по цене
                if (data.PriceTo != null)
                    madlanUrl += $"?filters=_0-{data.PriceTo}";

                links.Add(new SearchLink
                {
                    Site = "Madlan",
                    Url = madlanUrl,
                    Description = "Районы, цены и аналитика"
                });
            }
            else
            {
                links.Add(new SearchLink
                {
                    Site = "Madlan",
                    Url = "https://www.madlan.co.il/for-rent",
                    Description = "Поиск по карте"
                });
            }

            // =====================
            // 🟦 DOMIK
            // =====================
          var domikCityIds = new Dictionary<string, string>
{
    { "haifa", "4000" },
    { "tel-aviv", "5000" },
    { "bat-yam", "6200" },
    { "holon", "6300" },
    { "rishon", "8300" },
    { "petah-tikva", "7900" },
    { "beer-sheva", "9000" }
};

            if (!string.IsNullOrEmpty(city) && domikCityIds.TryGetValue(city, out var domikCityId))
            {
                var domikUrl =
                    $"https://domik.co.il/realty/rent/any/any/{city}?city_id={domikCityId}";

                if (data.PriceTo != null)
                    domikUrl += $"&price_to={data.PriceTo}";

                domikUrl += "&offer_type=rent&subtype=any&type=any";

                links.Add(new SearchLink
                {
                    Site = "Domik",
                    Url = domikUrl,
                    Description = "Русские объявления с фильтрами"
                });
            }
            else
            {
                links.Add(new SearchLink
                {
                    Site = "Domik",
                    Url = "https://domik.co.il",
                    Description = "Русские объявления"
                });
            }


            // =====================
            // 🟪 ONMAP
            // =====================
            if (!string.IsNullOrEmpty(city) &&
      CityMap.OnMap.TryGetValue(city, out var onMapCity))
            {
                var onMapUrl = $"https://onmap.co.il/search/homes/rent/{onMapCity}";

                if (data.PriceTo != null)
                    onMapUrl += $"/price_0-{data.PriceTo}";

                if (data.Rooms != null)
                    onMapUrl += $"/rooms_{data.Rooms}";

                onMapUrl += "/z_11";

                links.Add(new SearchLink
                {
                    Site = "OnMap",
                    Url = onMapUrl,
                    Description = "Поиск по карте"
                });
            }
            else
            {
                // fallback
                links.Add(new SearchLink
                {
                    Site = "OnMap",
                    Url = "https://onmap.co.il/search/homes/rent",
                    Description = "Поиск по карте"
                });
            }
            // =====================
            // 🟫 ORBITA
            // =====================
            if (!string.IsNullOrEmpty(city) &&
     CityMap.Orbita.TryGetValue(city, out var orbitaCity))
            {
                var orbitaUrl =
                    $"https://doska.orbita.co.il/search/?q={Uri.EscapeDataString(orbitaCity)}&engine=g&cat_show=5";

                links.Add(new SearchLink
                {
                    Site = "Orbita",
                    Url = orbitaUrl,
                    Description = "Русская доска объявлений"
                });
            }
            else
            {
                links.Add(new SearchLink
                {
                    Site = "Orbita",
                    Url = "https://doska.orbita.co.il/search/?engine=g&cat_show=5",
                    Description = "Русская доска объявлений"
                });
            }

            //////// =====================
            //////// 🟦 ALKESEF
            //////// =====================
            ///
            //////links.Add(new SearchLink
            //////{
            //////    Site = "Alkesef",
            //////    Url = "https://www.alkesef.co.il",
            //////    Description = "Долгосрочная аренда"
            //////});

            //////// =====================
            //////// 🌍 iHOMES
            //////// =====================
            //////links.Add(new SearchLink
            //////{
            //////    Site = "iHomes",
            //////    Url = "https://www.ihomes.co.il",
            //////    Description = "Аренда для иностранцев"
            //////});

            // =====================
            // 🌍 BUY IT IN ISRAEL
            // =====================
            if (!string.IsNullOrEmpty(city) &&
       CityMap.BuyItInIsraelLocation.TryGetValue(city, out var locationId))
            {
                var url = $"https://buyitinisrael.com/projects-list/?location={locationId}";

                if (data.Rooms != null &&
                    CityMap.BuyItInIsraelRooms.TryGetValue(data.Rooms.Value, out var roomsId))
                {
                    url += $"&rooms={roomsId}";
                }

                if (data.PriceTo != null)
                    url += $"&currency=ILS&price={data.PriceTo}";

                links.Add(new SearchLink
                {
                    Site = "BuyItInIsrael",
                    Url = url,
                    Description = "Англоязычный портал (новые проекты)"
                });
            }
            else
            {
                links.Add(new SearchLink
                {
                    Site = "BuyItInIsrael",
                    Url = "https://buyitinisrael.com/projects-list/",
                    Description = "Англоязычный портал (новые проекты)"
                });
            }

            // =====================
            // 🌍 REALTOR
            // =====================
            links.Add(new SearchLink
            {
                Site = "Realtor",
                Url = "https://www.realtor.com/international/il/",
                Description = "Международная недвижимость"
            });

            // =====================
            // 📘 FACEBOOK
            // =====================
            if (!string.IsNullOrEmpty(city))
            {
                links.Add(new SearchLink
                {
                    Site = "Facebook",
                    Url = $"https://www.facebook.com/search/groups/?q=rent%20{Uri.EscapeDataString(city)}",
                    Description = "Группы без маклеров"
                });
            }

            return links;
        }
    }
}
