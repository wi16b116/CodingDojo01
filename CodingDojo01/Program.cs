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
            Menu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Temperature in celcius to convert: ");
                    string celcius = Console.ReadLine();
                    float theCelciusTemp = float.Parse(celcius);
                    CelciusConverter(theCelciusTemp);
                    break;
                case "2":
                    Console.Write("Temperature in fahrenheit to convert: ");
                    string fahrenheit = Console.ReadLine();
                    float theFahrenheitTemp = float.Parse(fahrenheit);
                    FahrenheitConverter(theFahrenheitTemp);
                    break;
                case "3":
                    Console.Write("Temperature in reaumur to convert: ");
                    string reaumur = Console.ReadLine();
                    float theReaumurTemp = float.Parse(reaumur);
                    ReaumurConverter(theReaumurTemp);
                    break;
                //case "4":
                //    KelvinConverter();
                //    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 4.");
                    break;
            }

            Console.ReadLine();

        }

        public static void CelciusConverter(float temp)
        {
            Console.WriteLine(temp + " Celcius converted: \n" +
                "Fahrenheit: {0} \n" + 
                "Reaumur: {1} \n" +
                "Kelvin: {2}", (temp * 1.8 + 32), (temp * 0.8), (temp + 237.15));
        }

        public static void FahrenheitConverter(float temp)
        { 
             Console.WriteLine(temp + " Fahrenheit converted: \n" +
                "Celcius: {0} \n" + 
                "Reaumur: {1} \n" +
                "Kelvin: {2}", ((temp - 32) / 1.8), ((temp - 32) / 2.25), ((temp + 459.67) / 1.8));
        }

        public static void ReaumurConverter(float temp)
        {
            Console.WriteLine(temp + " Reaumur converted: \n" +
               "Celcius: {0} \n" +
               "Fahrenheit: {1} \n" +
               "Kelvin: {2}", ((temp - 32) / 1.8), ((temp - 32) / 2.25), ((temp + 459.67) / 1.8));
        }

        public  static void Menu()
        {
            Console.WriteLine("Unit to convert from: \n" +
               "1. Celcius \n" +
               "2. Fahrenheit \n" +
               "3. Reaumur \n" +
               "4. Kelvin");
        }
    }
}
