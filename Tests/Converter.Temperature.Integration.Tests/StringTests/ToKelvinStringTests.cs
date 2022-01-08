namespace Converter.Temperature.Integration.Tests.StringTests
{
    using System;
    using System.Globalization;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToKelvinStringTests
    {
        #region From Celsius

        [Fact]
        public void Test_string_extensions_from_celsius_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            const string input = "200";

            // Act.
            var result = input.FromCelsius().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            const string input = "200";

            // Act.
            var result = input.From<Celsius>().To<Kelvin>();

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

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).From<Celsius>().To<Kelvin>());

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
            const string input = "392";

            // Act.
            var result = input.FromFahrenheit().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            const string input = "392";

            // Act.
            var result = input.From<Fahrenheit>().To<Kelvin>();

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

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_and_to_kelvin_returns_correct_string_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Kelvin>().To<Kelvin>();

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
            const string input = "6";

            // Act.
            var result = input.FromGas().ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extension_generic_from_gas_to_kelvin_returns_correct_value()
        {
            // Arrange.
            const string expected = "473.15";
            const string input = "6";

            // Act.
            var result = input.From<Gas>().To<Kelvin>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(-1000d, -555.5555555555555d)]
        [InlineData(0d, 0d)]
        [InlineData(50d, 27.77777777777778d)]
        [InlineData(100d, 55.55555555555556d)]
        [InlineData(500d, 277.77777777777777d)]
        [InlineData(1000d, 555.5555555555555d)]
        public void Test_string_extension_from_rankine_and_to_kelvin_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromRankine().ToKelvin();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(-1000d, -555.5555555555555d)]
        [InlineData(0d, 0d)]
        [InlineData(50d, 27.77777777777778d)]
        [InlineData(100d, 55.55555555555556d)]
        [InlineData(500d, 277.77777777777777d)]
        [InlineData(1000d, 555.5555555555555d)]
        public void Test_string_extension_generic_from_rankine_and_to_kelvin_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Rankine>().To<Kelvin>();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Rankine
    }
}
