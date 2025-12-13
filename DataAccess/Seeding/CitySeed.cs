using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedCities(ModelBuilder modelBuilder)
        {
            var cities = new List<CityEntity>();
            int id = 1;

            var map = new Dictionary<int, List<(string en, string ar)>>
            {
                // Cairo (1)
                {1, new List<(string,string)>{ ("Nasr City","مدينة نصر"), ("Heliopolis","مصر الجديدة"), ("Maadi","المعادي"), ("Zamalek","الزمالك"), ("Mokattam","المقطم"), ("Giza Corniche","كورنيش الجيزة") } },
                // Giza (2)
                {2, new List<(string,string)>{ ("Dokki","الدقي"), ("6th of October","6 أكتوبر"), ("Sheikh Zayed","الشيخ زايد"), ("Haram","الهرم") } },
                // Alexandria (3)
                {3, new List<(string,string)>{ ("Sidi Gaber","سيدي جابر"), ("Smouha","سموحة"), ("Stanley","ستانلي"), ("Glim","جليم") } },
                // Suez (4)
                {4, new List<(string,string)>{ ("Suez City","مدينة السويس") } },
                // Port Said (5)
                {5, new List<(string,string)>{ ("Port Said City","بورسعيد") } },
                // Damietta (6)
                {6, new List<(string,string)>{ ("Damietta City","دمياط") } },
                // Daqahlia (7)
                {7, new List<(string,string)>{ ("Mansoura","المنصورة"), ("Talkha","طلخا") } },
                // Sharqia (8)
                {8, new List<(string,string)>{ ("Zagazig","الزقازيق"), ("Belbeis","بلبيس") } },
                // Gharbia (9)
                {9, new List<(string,string)>{ ("Tanta","طنطا"), ("Mahalla","المحلة") } },
                // Kafr El Sheikh (10)
                {10, new List<(string,string)>{ ("Kafr El Sheikh City","كفر الشيخ") } },
                // Beheira (11)
                {11, new List<(string,string)>{ ("Damanhour","دمنهور") } },
                // Fayoum (12)
                {12, new List<(string,string)>{ ("Fayoum City","الفيوم"), ("Ihnasia","إطسا") } },
                // Beni Suef (13)
                {13, new List<(string,string)>{ ("Beni Suef City","بني سويف") } },
                // Minya (14)
                {14, new List<(string,string)>{ ("Minya City","المنيا") } },
                // Asyut (15)
                {15, new List<(string,string)>{ ("Asyut City","أسيوط") } },
                // Sohag (16)
                {16, new List<(string,string)>{ ("Sohag City","سوهاج") } },
                // Qena (17)
                {17, new List<(string,string)>{ ("Qena City","قنا") } },
                // Luxor (18)
                {18, new List<(string,string)>{ ("Luxor City","الأقصر") } },
                // Aswan (19)
                {19, new List<(string,string)>{ ("Aswan City","أسوان") } },
                // Red Sea (20)
                {20, new List<(string,string)>{ ("Hurghada","الغردقة"), ("Safaga","سفاجا"), ("Marsa Alam","مرسى علم") } },
                // New Valley (21)
                {21, new List<(string,string)>{ ("New Valley City","الوادي الجديد") } },
                // Matrouh (22)
                {22, new List<(string,string)>{ ("Marsa Matrouh","مرسى مطروح"), ("Siwa","سيوة") } },
                // North Sinai (23)
                {23, new List<(string,string)>{ ("Arish","العريش") } },
                // South Sinai (24)
                {24, new List<(string,string)>{ ("Sharm El-Sheikh","شرم الشيخ"), ("Taba","طابا") } },
                // Ismailia (25)
                {25, new List<(string,string)>{ ("Ismailia City","الإسماعيلية") } }
            };

            // generate lat/long simple placeholders (+ small offsets)
            var rnd = new Random(12345);
            foreach (var kv in map)
            {
                foreach (var tuple in kv.Value)
                {
                    cities.Add(new CityEntity
                    {
                        Id = id++,
                        Name = tuple.en,
                        ArabicName = tuple.ar,
                        GovernorateId = kv.Key,
                        Latitude = Math.Round((decimal)(29.5 + rnd.NextDouble() * 2.5 + (kv.Key * 0.01)), 6),
                        Longitude = Math.Round((decimal)(30.5 + rnd.NextDouble() * 2.5 + (kv.Key * 0.01)), 6)
                    });
                }
            }

            modelBuilder.Entity<CityEntity>().HasData(cities.ToArray());
        }
    }
}
