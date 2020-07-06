using StaticExerciseConsoleUI;
using System;

namespace StaticTempConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temp Converter!");


            string decision;
            string[] choice = { "1. Fahrenheit to Celsius", "2. Celsius to Fahrenheit", "Exit" };

            do
            {
            choice[0] = "1";
            choice[1] = "2";
            choice[2] = "3";

            Console.WriteLine("Choose which option youd like to do: 1. Fahrenheit to Celsius OR 2. Celsius to Fahrenheit (3) To Exit.");
            Console.WriteLine("*Enter the number only*");
            decision = Console.ReadLine();
            
                if (decision == "1")
                {
                    Console.WriteLine("Enter your Fahrenheit Temp to convert to Celsius ");
                    int tempF = int.Parse(Console.ReadLine());
                    Console.WriteLine(TempConverter.FahrenheitToCelsius(tempF));
                }
                else if (decision == "2")
                {
                    Console.WriteLine("Enter your Celsius Temp to convert to Fahrenheit ");
                    int tempC = int.Parse(Console.ReadLine());
                    Console.WriteLine(TempConverter.CelsiusToFahrenheit(tempC));
                }
            } while (decision != "3");
        }
    }
}
