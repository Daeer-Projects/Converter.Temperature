using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests
{
    public class ToKelvinIntTests
    {

        #region From Celsius

        [Theory]
        [InlineData(200, 473)]
        [InlineData(int.MinValue, -2147483375)]
        public void Test_int_extensions_from_celsius_to_kelvin_returns_correct_value(int input, int expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_int_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception()
        {
            // Arrange.
            const int input = int.MaxValue;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_int_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = 392;

            // Act.
            var result = input.FromFahrenheit().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0.0)]
        [InlineData(7564)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_kelvin_returns_correct_int_value(int value)
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
        public void Test_int_extension_from_gas_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = 6;

            // Act.
            var result = input.FromGas().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas
    }
}
