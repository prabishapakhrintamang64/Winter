using System;
namespace Application
{
    class Problem41
    {
        public static void solution()
        {
            //Sttring Interpolation
            string city ="Kathmandu";
            string country =" Nepal";
            //use string interpoltion to concatenate strings
            string citycounrty =$"{city} is a city in {country}.";
            Console.WriteLine(citycounrty);
        }
    }
}