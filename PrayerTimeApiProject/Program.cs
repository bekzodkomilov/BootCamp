using System;
using System.Text.Json;
using System.Threading.Tasks;
using lesson10.Dto.PrayerTime;
using lesson10.Dto.User;
using lesson10.Services;

namespace lesson10
{
    class Program
    {
        private static string usersApi = "https://randomuser.me/api/";
        public static string Joy(string city, string country)
        {
          return $"http://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method=8";
        } 
        static async Task Main(string[] args)
        {
            Console.Write("Shaharingizni kiriting: ");
            string city = Console.ReadLine();
            Console.Write("Mamlakat: ");
            string country = Console.ReadLine();
            var prayerTimeApi = Joy(city,country);
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);

            if(result.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                // var json = JsonSerializer.Serialize(result.Data, settings);
                var date = JsonSerializer.Serialize(result.Data.Data.Date.Gregorian.Date, settings).Replace("\"", "");
                Console.WriteLine($"\nSana: {date}");
                var json = JsonSerializer.Serialize(result.Data.Data.Timings.Fajr, settings).Replace("\"", "");
                Console.WriteLine($"Bomdod vaqti:         {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Sunrise, settings).Replace("\"", "");
                Console.WriteLine($"Quyosh chiqish vaqti: {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Dhuhr, settings).Replace("\"", "");
                Console.WriteLine($"Peshin vaqti:         {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Asr, settings).Replace("\"", "");
                Console.WriteLine($"Asr vaqti:            {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Sunset, settings).Replace("\"", "");
                Console.WriteLine($"Quyosh botish vaqti:  {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Maghrib, settings).Replace("\"", "");
                Console.WriteLine($"Shom vaqti:           {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Isha, settings).Replace("\"", "");
                Console.WriteLine($"Xufton vaqti:         {json}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
        static async Task Main_user(string[] args)
        {
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<User>(usersApi);

            if(result.IsSuccess)
            {
                Console.WriteLine($"{result.Data.Results[0].Name.First}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
    }
}
