using System;

namespace Converter.Temperature
{
    /// <summary>
    /// The Temperature converter class.
    /// </summary>
    internal static class Temperature
    {
        /// <summary>
        /// The celsius to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToCelsius(double firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The celsius to fahrenheit conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToFahrenheit(double input)
        {
            var fahrenheitTemp = (input * 1.8) + 32;
            if (double.IsPositiveInfinity(fahrenheitTemp) || double.IsNegativeInfinity(fahrenheitTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            return fahrenheitTemp;
        }

        /// <summary>
        /// The celsius to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToKelvin(double input)
        {
            var experimentTemp = (input * 1.01d) + 273.15d;
            if (double.IsPositiveInfinity(experimentTemp) || double.IsNegativeInfinity(experimentTemp))
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            var kelvinTemp = (input * 1d) + 273.15d;

            return kelvinTemp;
        }

        /// <summary>
        /// The celsius to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToGas(double input)
        {
            double gasTemp;
            if (input < 80)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError);
            }

            if (input < 115)
            {
                gasTemp = 0.25;
            }
            else if (input < 135)
            {
                gasTemp = 0.5;
            }
            else if (input < 145)
            {
                gasTemp = 1;
            }
            else if (input < 155)
            {
                gasTemp = 2;
            }
            else if (input < 175)
            {
                gasTemp = 3;
            }
            else if (input < 185)
            {
                gasTemp = 4;
            }
            else if (input < 195)
            {
                gasTemp = 5;
            }
            else if (input < 210)
            {
                gasTemp = 6;
            }
            else if (input < 225)
            {
                gasTemp = 7;
            }
            else if (input < 235)
            {
                gasTemp = 8;
            }
            else if (input < 245)
            {
                gasTemp = 9;
            }
            else if (input < 270)
            {
                gasTemp = 10;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooHighForGasError);
            }

            return gasTemp;
        }

        /// <summary>
        /// The fahrenheit to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToCelsius(double firstTemp)
        {
            var celsiusTemp = (firstTemp - 32) * 5 / 9;
            return celsiusTemp;
        }

        /// <summary>
        /// The fahrenheit to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToFahrenheit(double firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The fahrenheit to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToKelvin(double firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var kelvinTemp = CelsiusToKelvin(celsiusTemp);
            return kelvinTemp;
        }

        /// <summary>
        /// The fahrenheit to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double FahrenheitToGas(double firstTemp)
        {
            var celsiusTemp = FahrenheitToCelsius(firstTemp);
            var gasTemp = CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The kelvin to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double KelvinToCelsius(double firstTemp)
        {
            var celsiusTemp = firstTemp - 273.15;
            return celsiusTemp;
        }

        /// <summary>
        /// The kelvin to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double KelvinToFahrenheit(double firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var fahrenheitTemp = CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The kelvin to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double KelvinToKelvin(double firstTemp)
        {
            return firstTemp;
        }

        /// <summary>
        /// The kelvin to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double KelvinToGas(double firstTemp)
        {
            var celsiusTemp = KelvinToCelsius(firstTemp);
            var gasTemp = CelsiusToGas(celsiusTemp);
            return gasTemp;
        }

        /// <summary>
        /// The gas to celsius conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToCelsius(double input)
        {
            double celTemp;
            if (input < .25 || input > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);
            }

            if (input < 1)
            {
                celTemp = 125;
            }
            else if (input < 1.5)
            {
                celTemp = 140;
            }
            else if (input < 2.5)
            {
                celTemp = 150;
            }
            else if (input < 3.5)
            {
                celTemp = 165;
            }
            else if (input < 4.5)
            {
                celTemp = 180;
            }
            else if (input < 5.5)
            {
                celTemp = 190;
            }
            else if (input < 6.5)
            {
                celTemp = 200;
            }
            else if (input < 7.5)
            {
                celTemp = 220;
            }
            else if (input < 8.5)
            {
                celTemp = 230;
            }
            else if (input < 9.5)
            {
                celTemp = 240;
            }
            else
            {
                celTemp = 260;
            }

            return celTemp;
        }

        /// <summary>
        /// The gas to fahrenheit conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToFahrenheit(double firstTemp)
        {
            var celsiusTemp = GasToCelsius(firstTemp);
            var fahrenheitTemp = CelsiusToFahrenheit(celsiusTemp);
            return fahrenheitTemp;
        }

        /// <summary>
        /// The gas to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToKelvin(double firstTemp)
        {
            var celsiusTemp = GasToCelsius(firstTemp);
            var kelvinTemp = CelsiusToKelvin(celsiusTemp);
            return kelvinTemp;
        }

        /// <summary>
        /// The gas to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToGas(double input)
        {
            if (input < .25 || input > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureOutOfRangeError);
            }

            return input;
        }
    }
}