using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
    
       

        public static void GetWeather()
        {
            
        
            var apiKey = "35039b6d0e363ab83cf9a397a7368ed1";
            var cityName = Console.ReadLine();

            var client = new HttpClient();

            var cityUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
           
            var cityResponse = client.GetStringAsync(cityUrl).Result;

            var cityObject = JObject.Parse(cityResponse);

            Console.WriteLine(cityObject["main"]);
        }
    }
}
