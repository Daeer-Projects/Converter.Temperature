using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests
{
    public class ToKelvinFloatTests
    {
        #region From Celsius


        [Fact]
        public void Test_float_extensions_from_celsius_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const float expected = 473.15f;
            var input = 200f;

            // Act.
            var result = input.FromCelsius().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_float_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const float expected = 473.15f;
            var input = 392f;

            // Act.
            var result = input.FromFahrenheit().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65f)]
        [InlineData(0.0f)]
        [InlineData(7564.2334f)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_kelvin_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_float_extension_from_gas_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const float expected = 473.15f;
            var input = 6f;

            // Act.
            var result = input.FromGas().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas
    }
}
