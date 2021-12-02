namespace Converter.Temperature.Integration.Tests.FloatTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using Xunit;

    public class ToFahrenheitFloatTests
    {
        #region From Celsius

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

        #endregion From Celsius

        #region From Fahrenheit

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

        #endregion From Fahrenheit

        #region From Kelvin

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
        public void Test_float_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(float input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Kelvin

        #region From Gas

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

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(-1000d, -1459.67f)]
        [InlineData(0d, -459.67f)]
        [InlineData(50d, -409.67f)]
        [InlineData(100d, -359.67f)]
        [InlineData(500d, 40.329999999999984f)]
        [InlineData(1000d, 540.3299999999999f)]
        public void Test_float_extension_from_rankine_and_to_fahrenheit_returns_correct_float_value(float value, float expected)
        {
            // Arrange.
            // Act.
            var result = value.FromRankine().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Rankine
    }
}
