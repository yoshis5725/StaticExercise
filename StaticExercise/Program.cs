using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Celsius = {TempConverter.FahrenheitToCelsius(32)}");
            Console.WriteLine($"Fahrenheit = {TempConverter.CelsiusToFahrenheit(0)}");
        }
    }
}

