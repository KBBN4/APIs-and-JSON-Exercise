namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(" Kanye, GO:");
                Console.WriteLine();

                RonVSKanyeAPI.KanyeQuote();
                Console.WriteLine("-------");

                Console.WriteLine();

                Console.WriteLine(" Ron your turn:");

                Console.WriteLine();

                RonVSKanyeAPI.RonQuote();


            }
            #endregion

            #region
            Console.WriteLine(" ________________");
            Console.WriteLine("NEW TEMPERATURE");
            Console.WriteLine("______________________");
            Console.WriteLine();


            OpenWeatherMapAPI map = new OpenWeatherMapAPI();

            Console.WriteLine(" Enter a city you would like to see the tempature for : : ");


            Console.WriteLine();

            OpenWeatherMapAPI.GetWeather();


            Console.WriteLine("would you like to try a different city? Yes Or No ");
            var userInput = Console.ReadLine();


            if (userInput == "yes")
            {

                Console.WriteLine("-----------------");
                Console.WriteLine("NEW TEMPERATURE");
                Console.WriteLine("______________________");
                Console.WriteLine();




                Console.WriteLine(" Enter a city you would like to see the tempature for : : ");


                Console.WriteLine();

                OpenWeatherMapAPI.GetWeather();



            }
            else
            {
                Console.WriteLine(" Have a great day ! ");
            }
            #endregion














        }
    }
}