namespace Converter.Temperature.Integration.Tests.StringTests
{
    using System;
    using System.Globalization;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToFahrenheitStringTests
    {
        #region From Celsius

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).FromCelsius().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).From<Celsius>().To<Fahrenheit>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData("-152436784.334563", "-274386179.8022134")]
        [InlineData("0.0", "32")]
        [InlineData("26431662.73648262", "47577024.92566872")]
        public void Test_string_extension_from_celsius_and_to_fahrenheit_returns_correct_string_value(string input, string expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("-152436784.334563", "-274386179.8022134")]
        [InlineData("0.0", "32")]
        [InlineData("26431662.73648262", "47577024.92566872")]
        public void Test_string_extension_generic_from_celsius_and_to_fahrenheit_returns_correct_string_value(string input, string expected)
        {
            // Arrange.
            // Act.
            var result = input.From<Celsius>().To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_fahrenheit_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromFahrenheit().ToFahrenheit();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_and_to_fahrenheit_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Fahrenheit>().To<Fahrenheit>();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_string_extensions_from_kelvin_to_fahrenheit_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "33.8";
            const string input = "274.15";

            // Act.
            var result = input.FromKelvin().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "33.8";
            const string input = "274.15";

            // Act.
            var result = input.From<Kelvin>().To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).FromKelvin().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).From<Kelvin>().To<Fahrenheit>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_string_extensions_from_gas_to_fahrenheit_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "428";
            const string input = "7";

            // Act.
            var result = input.FromGas().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_gas_to_fahrenheit_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "428";
            const string input = "7";

            // Act.
            var result = input.From<Gas>().To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(-1000d, -1459.67d)]
        [InlineData(0d, -459.67d)]
        [InlineData(50d, -409.67d)]
        [InlineData(100d, -359.67d)]
        [InlineData(500d, 40.329999999999984d)]
        [InlineData(1000d, 540.3299999999999d)]
        public void Test_string_extension_from_rankine_and_to_fahrenheit_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromRankine().ToFahrenheit();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(-1000d, -1459.67d)]
        [InlineData(0d, -459.67d)]
        [InlineData(50d, -409.67d)]
        [InlineData(100d, -359.67d)]
        [InlineData(500d, 40.329999999999984d)]
        [InlineData(1000d, 540.3299999999999d)]
        public void Test_string_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Rankine>().To<Fahrenheit>();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Rankine
    }
}
