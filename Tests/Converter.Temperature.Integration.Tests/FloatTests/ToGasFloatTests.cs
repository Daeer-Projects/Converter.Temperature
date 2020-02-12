using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests
{
    public class ToGasFloatTests
    {
        #region From Celsius

        [Fact]
        public void Test_float_extensions_from_celsius_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 200f;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(80f, 0.25f)]
        [InlineData(114f, 0.25f)]
        [InlineData(115f, 0.5f)]
        [InlineData(134f, 0.5f)]
        [InlineData(135f, 1f)]
        [InlineData(144f, 1f)]
        [InlineData(145f, 2f)]
        [InlineData(154f, 2f)]
        [InlineData(155f, 3f)]
        [InlineData(174f, 3f)]
        [InlineData(175f, 4f)]
        [InlineData(184f, 4f)]
        [InlineData(185f, 5f)]
        [InlineData(194f, 5f)]
        [InlineData(195f, 6f)]
        [InlineData(209f, 6f)]
        [InlineData(210f, 7f)]
        [InlineData(224f, 7f)]
        [InlineData(225f, 8f)]
        [InlineData(234f, 8f)]
        [InlineData(235f, 9f)]
        [InlineData(244f, 9f)]
        [InlineData(245f, 10f)]
        [InlineData(269f, 10f)]
        public void Test_float_extensions_from_celsius_to_gas_returns_correct_gas_value(float input, float expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const float input = 74536.9876f;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Theory]
        [InlineData(79f, "Temp too low for gas mark!")]
        [InlineData(270f, "Temp too high for gas mark!")]
        public void Test_float_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(float input, string expectedError)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain(expectedError);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_float_extensions_from_fahrenheit_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 392f;

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_float_extensions_from_kelvin_to_gas_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 6f;
            const float input = 473.15f;

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(0.25f)]
        [InlineData(3f)]
        [InlineData(5f)]
        [InlineData(8f)]
        [InlineData(10f)]
        public void Test_float_extension_from_and_to_gas_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(0.24f)]
        [InlineData(10.1f)]
        public void Test_float_extension_from_and_to_gas_throws_exception(float value)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => value.FromGas().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas
    }
}
