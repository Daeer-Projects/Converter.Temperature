using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests
{
    public class FloatTests
    {
        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_celsius_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_fahrenheit_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromFahrenheit().ToFahrenheit();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_and_to_kelvin_returns_correct_float_value(float value)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(-152436784.334563d, -274386179.8022134d)]
        [InlineData(0.0d, 32.0d)]
        [InlineData(26431662.73648262d, 47577024.925668716d)]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_returns_correct_float_value(float input, float expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_with_max_value_throws_out_of_range_exception(float input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
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
        
        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_kelvin_and_to_fahrenheit_with_max_value_throws_out_of_range_exception(float input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }
    }
}