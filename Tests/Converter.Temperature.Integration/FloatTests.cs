using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration
{
    public class FloatTests
    {
        [Fact]
        public void Test_float_extension_from_and_to_celsius_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 39f;

            // Act.
            var result = expected.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 53.6f;
            const float input = 12f;

            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_with_max_value_returns_correct_float_value()
        {
            // Arrange.
            const float expected = float.MaxValue;
            const float input = float.MaxValue;

            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

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
    }
}