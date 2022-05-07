namespace Converter.Temperature.Converters.Celsius
{
    using System;

    internal static class CelsiusLongConversions
    {
        /// <summary>
        /// The celsius to celsius conversion.
        /// </summary>
        /// <param name="firstTemp"> The temperature to convert. </param>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long CelsiusToCelsius(long firstTemp)
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
        public static long CelsiusToFahrenheit(long input)
        {
            var fahrenheitTemp = (input * 1.8) + 32;
            if (fahrenheitTemp < long.MinValue || fahrenheitTemp > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            long fahrenheitTempLong = (long)Math.Round(fahrenheitTemp, 0, MidpointRounding.AwayFromZero);

            return fahrenheitTempLong;
        }

        /// <summary>
        /// The celsius to kelvin conversion.
        /// </summary>
        /// <param name="input"> The temperature to convert. </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"> If calculated value is beyond the limits of the type. </exception>
        /// <returns>
        /// The converted temperature.
        /// </returns>
        public static long CelsiusToKelvin(long input)
        {
            var kelvinTemp = input + 273L;
            // ToDo: This is wrong. long and int wrap around.
            if (kelvinTemp < long.MinValue || kelvinTemp > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

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
        public static long CelsiusToGas(long input)
        {
            long gasTemp;
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
        public static long CelsiusToRankine(long input)
        {
            var rankineTemp = (input + 273.15) * 9 / 5;
            if (rankineTemp < long.MinValue || rankineTemp > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(input), Constants.ValueOutOfRangeForType);
            }

            long rankineTempLong = (long)Math.Round(rankineTemp, 0, MidpointRounding.AwayFromZero);

            return rankineTempLong;
        }
    }
}
