using System;
namespace StaticExercise
{
	public class TempConverter
	{
		public TempConverter()
		{
		}


		// <-- Methods -->

		public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
			// (32°F − 32) × 5 / 9 = 0°C
			return ((fahrenheitTemp - 32) * 5) / 9;
		}


		public static double CelsiusToFahrenheit(double celsiusTemp)
        {
			// (0°C × 9/5) + 32 = 32°F
			return ((celsiusTemp * 9) /5) + 32;
		}
	}
}

