using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var response = client.GetStringAsync(ronUrl).Result;

            var ronArray = JArray.Parse(response);

            Console.WriteLine(ronArray[0]);
        }


        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeUrl = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;

            var kanyeObject = JObject.Parse(kanyeResponse);

            Console.WriteLine(kanyeObject["quote"]);
        }

    }
}