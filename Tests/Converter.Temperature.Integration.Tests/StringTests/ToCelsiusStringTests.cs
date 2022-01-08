namespace Converter.Temperature.Integration.Tests.StringTests
{
    using System;
    using System.Globalization;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToCelsiusStringTests
    {
        #region From Celsius

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_celsius_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_and_to_celsius_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Celsius>().To<Celsius>();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_string_extension_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
        {
            // Arrange.
            var input = double.MinValue.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_string_extension_generic_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
        {
            // Arrange.
            var input = double.MinValue.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Fahrenheit>().To<Celsius>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_string_extensions_from_fahrenheit_to_celsius_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "10";
            const string input = "50";

            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_fahrenheit_to_celsius_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "10";
            const string input = "50";

            // Act.
            var result = input.From<Fahrenheit>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_string_extensions_from_kelvin_to_celsius_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "1";
            const string input = "274.15";

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_kelvin_to_celsius_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "1";
            const string input = "274.15";

            // Act.
            var result = input.From<Kelvin>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
        {
            // Arrange.
            var expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
            var input = double.MinValue.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
        {
            // Arrange.
            var expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
            var input = double.MinValue.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = input.From<Kelvin>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(0.25d, 125d)]
        [InlineData(0.9d, 125d)]
        [InlineData(1d, 140d)]
        [InlineData(1.4d, 140d)]
        [InlineData(1.5d, 150d)]
        [InlineData(2.4d, 150d)]
        [InlineData(2.5d, 165d)]
        [InlineData(3.4d, 165d)]
        [InlineData(3.5d, 180d)]
        [InlineData(4.4d, 180d)]
        [InlineData(4.5d, 190d)]
        [InlineData(5.4d, 190d)]
        [InlineData(5.5d, 200d)]
        [InlineData(6.4d, 200d)]
        [InlineData(6.5d, 220d)]
        [InlineData(7.4d, 220d)]
        [InlineData(7.5d, 230d)]
        [InlineData(8.4d, 230d)]
        [InlineData(8.5d, 240d)]
        [InlineData(9.4d, 240d)]
        [InlineData(9.5d, 260d)]
        [InlineData(9.9d, 260d)]
        public void Test_string_extensions_from_gas_to_celsius_returns_correct_string_value(double input, double expected)
        {
            // Arrange.
            // Act.
            var result = input.ToString(CultureInfo.InvariantCulture).FromGas().ToCelsius();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(0.25d, 125d)]
        [InlineData(0.9d, 125d)]
        [InlineData(1d, 140d)]
        [InlineData(1.4d, 140d)]
        [InlineData(1.5d, 150d)]
        [InlineData(2.4d, 150d)]
        [InlineData(2.5d, 165d)]
        [InlineData(3.4d, 165d)]
        [InlineData(3.5d, 180d)]
        [InlineData(4.4d, 180d)]
        [InlineData(4.5d, 190d)]
        [InlineData(5.4d, 190d)]
        [InlineData(5.5d, 200d)]
        [InlineData(6.4d, 200d)]
        [InlineData(6.5d, 220d)]
        [InlineData(7.4d, 220d)]
        [InlineData(7.5d, 230d)]
        [InlineData(8.4d, 230d)]
        [InlineData(8.5d, 240d)]
        [InlineData(9.4d, 240d)]
        [InlineData(9.5d, 260d)]
        [InlineData(9.9d, 260d)]
        public void Test_string_extensions_generic_from_gas_to_celsius_returns_correct_string_value(double input, double expected)
        {
            // Arrange.
            // Act.
            var result = input.ToString(CultureInfo.InvariantCulture).From<Gas>().To<Celsius>();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData("0.24")]
        [InlineData("10.1")]
        public void Test_string_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(string input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        [Theory]
        [InlineData("0.24")]
        [InlineData("10.1")]
        public void Test_string_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(string input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>().To<Celsius>());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(0, -273.15d)]
        [InlineData(50, -245.3722222222222d)]
        [InlineData(100, -217.59444444444446d)]
        [InlineData(500, 4.627777777777769d)]
        [InlineData(1000, 282.40555555555557d)]
        public void Test_string_extension_from_rankine_and_to_celsius_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromRankine().ToCelsius();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(0, -273.15d)]
        [InlineData(50, -245.3722222222222d)]
        [InlineData(100, -217.59444444444446d)]
        [InlineData(500, 4.627777777777769d)]
        [InlineData(1000, 282.40555555555557d)]
        public void Test_string_extension_generic_from_rankine_and_to_celsius_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Rankine>().To<Celsius>();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Rankine
    }
}
