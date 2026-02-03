namespace FlatFinder.Api.Models
{
    public static class RegionMap
    {
        public static readonly Dictionary<string, RegionType> Map = new()
        {
            // ===== RU =====
            { "север", RegionType.North },
            { "на севере", RegionType.North },
            { "север израиля", RegionType.North },

            { "центр", RegionType.Center },
            { "в центре", RegionType.Center },
            { "центр израиля", RegionType.Center },

            { "иерусалим", RegionType.Jerusalem },
            { "йерусалим", RegionType.Jerusalem },

            { "юг", RegionType.South },
            { "на юге", RegionType.South },
            { "юг израиля", RegionType.South },

            // ===== HE =====
            { "אזור צפון", RegionType.North },
            { "בצפון", RegionType.North },
            { "צפון", RegionType.North },

            { "מרכז", RegionType.Center },
            { "אזור מרכז", RegionType.Center },

            { "ירושלים", RegionType.Jerusalem },

            { "דרום", RegionType.South },
            { "אזור דרום", RegionType.South },

            // ===== EN =====
            { "north", RegionType.North },
            { "center", RegionType.Center },
            { "jerusalem", RegionType.Jerusalem },
            { "south", RegionType.South }
        };
    }
}
