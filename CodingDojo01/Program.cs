using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit to convert from: \n" +
                "1. Celcius \n" +
                "2. Fahrenheit \n" +
                "3. Reaumur \n" +
                "4. Kelvin");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a temperature to convert: ");
                    string temp = Console.ReadLine();
                    CelciusConverter(temp);
                    Console.ReadLine();
                    break;
                //case "2":
                //    fahrenheitconverter();
                //    break;
                //case "3":
                //    reaumurconverter();
                //    break;
                //case "4":
                //    kelvinconverter();
                //    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 4.");
                    break;
            }

        }

        public static void CelciusConverter(string temp)
        {
            float newTemp = float.Parse(temp);
            Console.WriteLine(temp + " Celcius converted: \n" +
                "Fahrenheit: {0} \n" + 
                "Reaumur: {1} \n" +
                "Kelvin: {2}", (newTemp * 1.8 + 32), (newTemp * 0.8), (newTemp + 237.15));
        }
    }
}
