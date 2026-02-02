namespace FlatFinder.Api.Models
{
    public static class CityMap
    {
        public static readonly Dictionary<string, string> Yad2 = new()
         {
             // 🔹 Центр
             { "tel-aviv", "5000" },
             { "ramat-gan", "5250" },
             { "givatayim", "5300" },
             { "bnei-brak", "5100" },
             { "holon", "6300" },
             { "bat-yam", "6200" },
             { "petah-tikva", "7900" },
             { "rishon", "8300" },
             { "rehovot", "8400" },
             { "lod", "7000" },
             { "ramla", "7100" },
             { "herzliya", "6400" },
             { "raanana", "6500" },
             { "kfar-saba", "6600" },
             { "netanya", "7400" },
             { "hod-hasharon", "6700" },
         
             // 🔹 Север
             { "haifa", "4000" },
             { "karmiel", "2160" },
             { "nahariya", "2140" },
             { "akko", "2120" },
             { "tiberias", "2250" },
             { "afula", "2230" },
             { "nazareth", "2240" },
             { "nof-hagalil", "2245" },
             { "yokneam", "2210" },
             { "migdal-haemek", "2220" },
             { "kiryat-ata", "2200" },
             { "kiryat-bialik", "2201" },
             { "kiryat-motzkin", "2202" },
             { "kiryat-yam", "2203" },
             { "zichron-yaakov", "2150" },
             { "pardes-hanna", "2180" },
             { "hadera", "7200" },
         
             // 🔹 Юг
             { "beer-sheva", "9000" },
             { "ashdod", "8600" },
             { "ashkelon", "8700" },
             { "netivot", "8900" },
             { "ofakim", "8905" },
             { "kiryat-gat", "8800" },
             { "dimona", "9200" },
             { "eilat", "9300" },
         
             // 🔹 Иерусалим
             { "jerusalem", "3000" },
             { "beit-shemesh", "3100" }
         };

        public static readonly Dictionary<string, string> Madlan = new()
         {
 
           { "karmiel", "כרמיאל-ישראל" },
           { "carmiel", "כרמיאל-ישראל" },
           { "кармиэль", "כרמיאל-ישראל" },
           { "כרמיאל", "כרמיאל-ישראל" },
           
           // Netanya
           { "netanya", "נתניה-ישראל" },
           { "нетания", "נתניה-ישראל" },
           { "נתניה", "נתניה-ישראל" },
           
           // Ashdod
           { "ashdod", "אשדוד-ישראל" },
           { "ашдод", "אשדוד-ישראל" },
           { "אשדוד", "אשדוד-ישראל" },
           
           // Rehovot
           { "rehovot", "רחובות-ישראל" },
           { "реховот", "רחובות-ישראל" },
           { "רחובות", "רחובות-ישראל" },
           
           // Beer Sheva
           { "beer sheva", "באר-שבע-ישראל" },
           { "beer-sheva", "באר-שבע-ישראל" },
           { "беэр шева", "באר-שבע-ישראל" },
           { "באר שבע", "באר-שבע-ישראל" }

         };


        public static Dictionary<string, string> HomelessRegionMap = new()
         {
              // Север
            { "haifa", "8" },
            { "karmiel", "8" },
            { "nahariya", "8" },
            { "akko", "8" },
            { "tiberias", "8" },
            { "afula", "8" },
           
            // Центр
            { "tel-aviv", "7" },
            { "ramat-gan", "7" },
            { "holon", "7" },
            { "bat-yam", "7" },
            { "petah-tikva", "7" },
            { "netanya", "7" },
           
            // Иерусалим
            { "jerusalem", "6" },
           
            // Юг
            { "beer-sheva", "5" },
            { "ashdod", "5" },
            { "ashkelon", "5" },
            { "eilat", "5" }
         };
        public static readonly Dictionary<string, string> OnMap = new()
        {
               { "tel-aviv", "tel-aviv" },
            { "ramat-gan", "ramat-gan" },
            { "givatayim", "givatayim" },
            { "bnei-brak", "bnei-brak" },
            { "holon", "holon" },
            { "bat-yam", "bat-yam" },
            { "petah-tikva", "petah-tikva" },
            { "rishon", "rishon-lezion" },
            { "rehovot", "rehovot" },
            { "lod", "lod" },
            { "ramla", "ramla" },
            { "herzliya", "herzliya" },
            { "raanana", "raanana" },
            { "kfar-saba", "kfar-saba" },
            { "netanya", "netanya" },
            { "hod-hasharon", "hod-hasharon" },
           
            // 🔹 Север
            { "haifa", "haifa" },
            { "karmiel", "karmiel" },
            { "nahariya", "nahariya" },
            { "akko", "akko" },
            { "hadera", "hadera" },
            { "zichron-yaakov", "zichron-yaakov" },
            { "pardes-hanna", "pardes-hanna" },
            { "kiryat-ata", "kiryat-ata" },
            { "kiryat-bialik", "kiryat-bialik" },
            { "kiryat-motzkin", "kiryat-motzkin" },
            { "kiryat-yam", "kiryat-yam" },
            { "tiberias", "tiberias" },
            { "afula", "afula" },
            { "nazareth", "nazareth" },
            { "nof-hagalil", "nof-hagalil" },
           
            // 🔹 Иерусалим
            { "jerusalem", "jerusalem" },
            { "beit-shemesh", "beit-shemesh" },
           
            // 🔹 Юг
            { "beer-sheva", "beer-sheva" },
            { "ashdod", "ashdod" },
            { "ashkelon", "ashkelon" },
            { "kiryat-gat", "kiryat-gat" },
            { "netivot", "netivot" },
            { "ofakim", "ofakim" },
            { "dimona", "dimona" },
            { "eilat", "eilat" }
        };
        public static readonly Dictionary<string, string> Orbita = new()
         {
           // 🔹 Центр
             { "tel-aviv", "тель-авив" },
             { "ramat-gan", "рамат-ган" },
             { "givatayim", "гиватаим" },
             { "bnei-brak", "бней-брак" },
             { "holon", "холон" },
             { "bat-yam", "бат-ям" },
             { "petah-tikva", "петах-тиква" },
             { "rishon", "ришон ле-цион" },
             { "rehovot", "реховот" },
             { "lod", "лод" },
             { "ramla", "рамла" },
             { "herzliya", "герцлия" },
             { "raanana", "раанана" },
             { "kfar-saba", "кфар-саба" },
             { "netanya", "нетания" },
             { "hod-hasharon", "ход-хашарон" },
             
             // 🔹 Север
             { "haifa", "хайфа" },
             { "karmiel", "кармиэль" },
             { "nahariya", "нахария" },
             { "akko", "акко" },
             { "hadera", "хадера" },
             { "zichron-yaakov", "зихрон-яаков" },
             { "pardes-hanna", "пардес-хана" },
             { "kiryat-ata", "кирьят-ата" },
             { "kiryat-bialik", "кирьят-биалик" },
             { "kiryat-motzkin", "кирьят-моцкин" },
             { "kiryat-yam", "кирьят-ям" },
             { "tiberias", "тиверия" },
             { "afula", "афула" },
             { "nazareth", "назарет" },
             { "nof-hagalil", "ноф-ха-галиль" },
             
             // 🔹 Иерусалим
             { "jerusalem", "иерусалим" },
             { "beit-shemesh", "бейт-шемеш" },
             
             // 🔹 Юг
             { "beer-sheva", "беэр-шева" },
             { "ashdod", "ашдод" },
             { "ashkelon", "ашкелон" },
             { "kiryat-gat", "кирьят-гат" },
             { "netivot", "нетивот" },
             { "ofakim", "офаким" },
             { "dimona", "димона" },
             { "eilat", "эйлат" }
         };

        public static readonly Dictionary<string, string> BuyItInIsraelLocation = new()
         {
           // 🔹 Центр
            { "tel-aviv", "17047" },
            { "ramat-gan", "17049" },      // проверить
            { "givatayim", "17050" },      // проверить
            { "bnei-brak", "17051" },      // проверить
            { "holon", "17052" },          // проверить
            { "bat-yam", "17053" },        // проверить
            { "petah-tikva", "17054" },    // проверить
            { "rishon", "17055" },         // проверить
            { "rehovot", "17056" },        // проверить
            { "lod", "17057" },            // проверить
            { "ramla", "17058" },          // проверить
            { "herzliya", "17059" },       // проверить
            { "raanana", "17060" },        // проверить
            { "kfar-saba", "17061" },      // проверить
            { "netanya", "17062" },        // проверить
            { "hod-hasharon", "17063" },   // проверить
            
            // 🔹 Север
            { "haifa", "17226" },
            { "karmiel", "17227" },        // проверить
            { "nahariya", "17228" },       // проверить
            { "akko", "17229" },           // проверить
            { "hadera", "17230" },         // проверить
            { "zichron-yaakov", "17231" }, // проверить
            { "pardes-hanna", "17232" },   // проверить
            { "kiryat-ata", "17233" },     // проверить
            { "kiryat-bialik", "17234" },  // проверить
            { "kiryat-motzkin", "17235" }, // проверить
            { "kiryat-yam", "17236" },     // проверить
            { "tiberias", "17237" },       // проверить
            { "afula", "17238" },          // проверить
            { "nazareth", "17239" },       // проверить
            { "nof-hagalil", "17240" },    // проверить
            
            // 🔹 Иерусалим
            { "jerusalem", "17048" },
            { "beit-shemesh", "17064" },   // проверить
            
            // 🔹 Юг
            { "beer-sheva", "17312" },
            { "ashdod", "17313" },         // проверить
            { "ashkelon", "17314" },       // проверить
            { "kiryat-gat", "17315" },     // проверить
            { "netivot", "17316" },        // проверить
            { "ofakim", "17317" },         // проверить
            { "dimona", "17318" },         // проверить
            { "eilat", "17319" }           // проверить
         };
        public static readonly Dictionary<int, string> BuyItInIsraelRooms = new()
         {
              // 🏠 Studio
            { 0, "157596" }, // студия (проверь в URL)
           
            // 🛏 Комнаты
            { 1, "157597" },
            { 2, "157598" },
            { 3, "157599" },
            { 4, "157600" },
            { 5, "157601" }, // проверить
            { 6, "157602" }  // 6+ комнат, проверить
         };

    }
}

