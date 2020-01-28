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

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-345.65f)]
        [InlineData(0.0f)]
        [InlineData(7564.2334f)]
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
        [InlineData(float.MaxValue)]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(float input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(-152436784.334563f, -274386179.8022134f)]
        [InlineData(0.0f, 32.0f)]
        [InlineData(26431662.73648262f, 47577024.925668716f)]
        public void Test_float_extension_from_celsius_and_to_fahrenheit_returns_correct_float_value(float input, float expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extensions_from_gas_to_fahrenheit_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 428f;
            const float input = 7f;

            // Act.
            var result = input.FromGas().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_float_extensions_from_kelvin_to_fahrenheit_returns_correct_float_value()
        {
            // Arrange.
            const float expected = 33.8f;
            const float input = 274.15f;

            // Act.
            var result = input.FromKelvin().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(float.MaxValue)]
        public void Test_to_fahrenheit_from_kelvin_with_invalid_parameter_throws_exception(float input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

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