using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gotNum;
            double y;
            Console.WriteLine("Good Morning, please enter in a temperature to convert into Celsius");
            do
            {
                gotNum = double.TryParse(Console.ReadLine(), out double x);
                y = x;
                if (gotNum == false)
                {
                    Console.WriteLine("That is not a valid temperature. Please try again");
                }
                    
            } while (!gotNum);

            Console.WriteLine($"Here is that number in Fahrenheit {TempConverter.CelsiusToFahrenheit(y)}");

            Console.WriteLine("Now please enter another temperature in Fahrenheit to convert into Celsius");
            bool didLoop;            
            double y2;
            do
            {
                didLoop = double.TryParse(Console.ReadLine(),out double x);
                y2 = x;
                if (gotNum == false)
                {
                    Console.WriteLine("That is not a valid temperature. Please try again.");
                }


            } while (!gotNum);

            Console.WriteLine($"Here is that number in Celsius {TempConverter.FahrenheitToCelsius(y2)}");

        }
  
    
    }

    public class TempConverter
    {
        public static double FahrenheitToCelsius(double fahren)
        {

            double cel = (fahren - 32) / 1.8;
            return cel;
        }

        public static double CelsiusToFahrenheit(double cel)
        {
             double fahren = cel * 1.8 + 32;
            return fahren;
        }

    }



}



