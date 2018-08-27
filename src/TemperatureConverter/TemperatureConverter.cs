using System;

namespace TemperatureConverter
{
    /// <summary>
    /// Temperature converter class.
    /// </summary>
    internal static class TemperatureConverter
    {
        /// <summary>
        /// Temperature out of range error message.
        /// </summary>
        private const string TemperatureOutOfRangeError = "Temp too low or too high for gas mark!";

        /// <summary>
        /// Temperature too high error message.
        /// </summary>
        private const string TemperatureTooHighForGasError = "Temp too high for gas mark!";

        /// <summary>
        /// Temperature too low error message.
        /// </summary>
        private const string TemperatureTooLowForGasError = "Temp too low for gas mark!";

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
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToFahrenheit(double firstTemp)
        {
            var fahrenheitTemp = (firstTemp * 1.8) + 32;
            return fahrenheitTemp;
        }

        /// <summary>
        /// The celsius to kelvin conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToKelvin(double firstTemp)
        {
            var kelvinTemp = firstTemp + 273.15;
            return kelvinTemp;
        }

        /// <summary>
        /// The celsius to gas conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double CelsiusToGas(double firstTemp)
        {
            double gasTemp;
            if (firstTemp < 80)
            {
                throw new ArgumentOutOfRangeException(TemperatureTooLowForGasError);
            }
            else if (firstTemp < 115)
            {
                gasTemp = 0.25;
            }
            else if (firstTemp < 135)
            {
                gasTemp = 0.5;
            }
            else if (firstTemp < 145)
            {
                gasTemp = 1;
            }
            else if (firstTemp < 155)
            {
                gasTemp = 2;
            }
            else if (firstTemp < 175)
            {
                gasTemp = 3;
            }
            else if (firstTemp < 185)
            {
                gasTemp = 4;
            }
            else if (firstTemp < 195)
            {
                gasTemp = 5;
            }
            else if (firstTemp < 210)
            {
                gasTemp = 6;
            }
            else if (firstTemp < 225)
            {
                gasTemp = 7;
            }
            else if (firstTemp < 235)
            {
                gasTemp = 8;
            }
            else if (firstTemp < 245)
            {
                gasTemp = 9;
            }
            else if (firstTemp < 270)
            {
                gasTemp = 10;
            }
            else
            {
                throw new ArgumentOutOfRangeException(TemperatureTooHighForGasError);
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
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToCelsius(double firstTemp)
        {
            double celTemp;
            if (firstTemp < .25 || firstTemp > 10)
            {
                throw new ArgumentOutOfRangeException(TemperatureOutOfRangeError);
            }
            else if (firstTemp < 1)
            {
                celTemp = 125;
            }
            else if (firstTemp < 1.5)
            {
                celTemp = 140;
            }
            else if (firstTemp < 2.5)
            {
                celTemp = 150;
            }
            else if (firstTemp < 3.5)
            {
                celTemp = 165;
            }
            else if (firstTemp < 4.5)
            {
                celTemp = 180;
            }
            else if (firstTemp < 5.5)
            {
                celTemp = 190;
            }
            else if (firstTemp < 6.5)
            {
                celTemp = 200;
            }
            else if (firstTemp < 7.5)
            {
                celTemp = 220;
            }
            else if (firstTemp < 8.5)
            {
                celTemp = 230;
            }
            else if (firstTemp < 9.5)
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
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
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
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <exception cref="ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static double GasToGas(double firstTemp)
        {
            if (firstTemp < .25 || firstTemp > 10)
            {
                throw new ArgumentOutOfRangeException(TemperatureOutOfRangeError);
            }
            else
            {
                return firstTemp;
            }
        }
    }
}