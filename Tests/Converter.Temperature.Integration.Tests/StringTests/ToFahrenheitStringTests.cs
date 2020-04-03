using System;
using System.Globalization;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests
{
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

        #endregion From Gas
    }
}
