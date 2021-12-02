namespace Converter.Temperature.Integration.Tests.DoubleTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using Xunit;

    public class ToFahrenheitDoubleTests
    {
        #region From Celsius

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_double_extension_from_celsius_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(-152436784.334563d, -274386179.8022134d)]
        [InlineData(0.0d, 32.0d)]
        [InlineData(26431662.73648262d, 47577024.925668716d)]
        public void Test_double_extension_from_celsius_and_to_fahrenheit_returns_correct_double_value(double input, double expected)
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
        public void Test_double_extension_from_and_to_fahrenheit_returns_correct_double_value(double value)
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
        public void Test_double_extensions_from_kelvin_to_fahrenheit_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 33.8d;
            const double input = 274.15d;

            // Act.
            var result = input.FromKelvin().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_double_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(double input)
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
        public void Test_double_extensions_from_gas_to_fahrenheit_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 428d;
            const double input = 7d;

            // Act.
            var result = input.FromGas().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(-1000d, -1459.67d)]
        [InlineData(0d, -459.67d)]
        [InlineData(50d, -409.67d)]
        [InlineData(100d, -359.67d)]
        [InlineData(500d, 40.329999999999984d)]
        [InlineData(1000d, 540.3299999999999d)]
        public void Test_double_extension_from_rankine_and_to_fahrenheit_returns_correct_double_value(double value, double expected)
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
