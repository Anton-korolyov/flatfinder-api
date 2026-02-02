namespace FlatFinder.Api.Models
{
    public static class CityMap
    {
        public static readonly Dictionary<string, string> Yad2 = new()
         {
             { "haifa", "4000" },
             { "tel-aviv", "5000" },
             { "bat-yam", "6200" },
             { "holon", "6300" },
             { "rishon", "8300" },
             { "petah-tikva", "7900" },
             { "beer-sheva", "9000" }
         };

        public static readonly Dictionary<string, string> Madlan = new()
         {
             { "хайфа", "חיפה-ישראל" },
             { "haifa", "חיפה-ישראל" },
             { "חיפה", "חיפה-ישראל" },
             
             { "кирьят моцкин", "קרית-מוצקין-ישראל" },
             { "kiryat motzkin", "קרית-מוצקין-ישראל" },
             { "קרית מוצקין", "קרית-מוצקין-ישראל" },
             
             { "тель-авив", "תל-אביב-יפו-ישראל" },
             { "tel aviv", "תל-אביב-יפו-ישראל" },
             { "תל אביב", "תל-אביב-יפו-ישראל" }
         };


        public static Dictionary<string, string> HomelessRegionMap = new()
         {
             { "haifa", "8" },
             { "tel-aviv", "7" },
             { "jerusalem", "6" },
             { "beer-sheva", "5" }
         };
        public static readonly Dictionary<string, string> OnMap = new()
        {
            { "haifa", "haifa" },
            { "tel-aviv", "tel-aviv" },
            { "jerusalem", "jerusalem" },
            { "beer-sheva", "beer-sheva" }
        };
        public static readonly Dictionary<string, string> Orbita = new()
         {
             { "haifa", "хайфа" },
             { "tel-aviv", "тель-авив" },
             { "bat-yam", "бат-ям" },
             { "holon", "холон" },
             { "rishon", "ришон лецион" },
             { "beer-sheva", "беэр-шева" }
         };

        public static readonly Dictionary<string, string> BuyItInIsraelLocation = new()
         {
             { "haifa", "17226" },
             { "tel-aviv", "17047" },
             { "jerusalem", "17048" },
             { "beer-sheva", "17312" },
             { "kiryat-gat", "17226" } // пример, замени при необходимости
         };
        public static readonly Dictionary<int, string> BuyItInIsraelRooms = new()
         {
             { 1, "157597" },
             { 2, "157598" },
             { 3, "157599" },
             { 4, "157600" }
         };

    }
}

