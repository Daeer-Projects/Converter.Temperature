using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests
{
    public class ToCelsiusFloatTests
    {

        #region From Celsius

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65f)]
        [InlineData(0.0f)]
        [InlineData(7564.2334f)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_celsius_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_float_extension_from_fahrenheit_and_to_celsius_with_min_value_returns_correct_float_value()
        {
            // Arrange.
            const float expected = -1.8904574813251603E+38f;
            const float input = float.MinValue;

            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extensions_from_fahrenheit_to_celsius_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 10f;
            const float input = 50f;

            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_float_extensions_from_kelvin_to_celsius_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 1.0f;
            const float input = 274.15f;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_float_value()
        {
            // Arrange.
            const float expected = float.MinValue;
            const float input = float.MinValue;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_float_extensions_from_gas_to_celsius_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 220f;
            const float input = 7f;

            // Act.
            var result = input.FromGas().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas
    }
}
