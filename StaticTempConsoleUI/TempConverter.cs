using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExerciseConsoleUI
{
    static class TempConverter
    {

       
        public static int FahrenheitToCelsius(int fahTemp)
        {
            int answer = (fahTemp - 32) * 5 / 9;
            return answer;
        }
        public static int CelsiusToFahrenheit(int celTemp)
        {
            int answer = (celTemp * 9) / 5 + 32;
            return answer;
        }

            
    }
}
