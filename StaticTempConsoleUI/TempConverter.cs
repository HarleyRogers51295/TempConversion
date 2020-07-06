using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExerciseConsoleUI
{
    public static class TempConverter
    {

       
        public static double FahrenheitToCelsius(double fahTemp)
        {
            double answer = (fahTemp - 32) * 5 / 9;
            return answer;
        }
        public static double CelsiusToFahrenheit(double celTemp)
        {
            double answer = (celTemp * 9) / 5 + 32;
            return answer;
        }
        public static double FahrenheitToCelsius1(double fahTemp)
        {
            double answer = (fahTemp - 32)/1.8; //This is to have a different method
            return answer;
        }
        public static double CelsiusToFahrenheit1(double celTemp)
        {
            double answer = (celTemp * 1.8) + 32; //This is to have a different method
            return answer;
        }

    }
}
