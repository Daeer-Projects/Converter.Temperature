namespace Converter.Temperature.Converters.Celsius
{
    using System;

    internal static class CelsiusIntConversions
    {
        /// <summary>
        /// The celsius to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int CelsiusToCelsius(int firstTemp)
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
        public static int CelsiusToFahrenheit(int input)
        {
            var fahrenheitTemp = (input * 1.8) + 32;
            if (fahrenheitTemp < int.MinValue || fahrenheitTemp > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            int fahrenheitTempInt = (int)Math.Round(fahrenheitTemp, 0, MidpointRounding.AwayFromZero);

            return fahrenheitTempInt;
        }

        /// <summary>
        /// The celsius to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int CelsiusToKelvin(int input)
        {
            const int maxValue = int.MaxValue - 273;
            const int minValue = int.MinValue + 273;
            if (input < minValue || input > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            int kelvinTempInt = input + 273;

            return kelvinTempInt;
        }

        /// <summary>
        /// The celsius to gas conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> Temp too low or too high for gas mark! </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int CelsiusToGas(int input)
        {
            int gasTemp;
            if (input < 135)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.TemperatureTooLowForGasError);
            }

            if (input < 145)
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
        /// The celsius to rankine conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static int CelsiusToRankine(int input)
        {
            const int minValue = int.MinValue + 492;
            const int maxValue = int.MaxValue - 492;
            if (input < minValue || input > maxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            double result = (input + 273.15d) * 9 / 5;
            int rankineTempInt = (int)Math.Round(result, 0, MidpointRounding.AwayFromZero);

            return rankineTempInt;
        }
    }
}
