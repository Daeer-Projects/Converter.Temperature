using System;
using System.Globalization;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests
{
    public class ToKelvinStringTests
    {
        #region From Celsius

        [Fact]
        public void Test_string_extensions_from_celsius_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = "200";

            // Act.
            var result = input.FromCelsius().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).FromCelsius().ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_string_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = "392";

            // Act.
            var result = input.FromFahrenheit().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_kelvin_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_string_extension_from_gas_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            var input = "6";

            // Act.
            var result = input.FromGas().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas
    }
}
