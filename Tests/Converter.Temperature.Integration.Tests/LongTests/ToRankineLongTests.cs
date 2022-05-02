namespace Converter.Temperature.Integration.Tests.LongTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToRankineLongTests
    {
        #region From Celsius

        [Fact]
        public void Test_long_extensions_from_celsius_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 200L;

            // Act.
            var result = input.FromCelsius().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_celsius_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 200L;

            // Act.
            var result = input.From<Celsius>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        public void Test_long_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(long input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(long.MaxValue)]
        public void Test_long_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(long input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>().To<Rankine>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_long_extensions_from_fahrenheit_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 392L;

            // Act.
            var result = input.FromFahrenheit().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 392L;

            // Act.
            var result = input.From<Fahrenheit>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(-1000L, -1800L)]
        [InlineData(0L, 0L)]
        [InlineData(50L, 90L)]
        [InlineData(1000L, 1800L)]
        public void Test_long_extension_from_kelvin_to_rankine_returns_correct_long_value(long value, long expected)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(-1000L, -1800L)]
        [InlineData(0L, 0L)]
        [InlineData(50L, 90L)]
        [InlineData(1000L, 1800L)]
        public void Test_long_extension_generic_from_kelvin_to_rankine_returns_correct_long_value(long value, long expected)
        {
            // Arrange.
            // Act.
            var result = value.From<Kelvin>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_long_extension_from_gas_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 6L;

            // Act.
            var result = input.FromGas().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extension_generic_from_gas_to_rankine_returns_correct_value()
        {
            // Arrange.
            const long expected = 852L;
            const long input = 6L;

            // Act.
            var result = input.From<Gas>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(-345L)]
        [InlineData(0L)]
        [InlineData(7564L)]
        [InlineData(long.MaxValue)]
        public void Test_long_extension_from_and_to_rankine_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.FromRankine().ToRankine();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(-345L)]
        [InlineData(0L)]
        [InlineData(7564L)]
        [InlineData(long.MaxValue)]
        public void Test_long_extension_generic_from_and_to_rankine_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.From<Rankine>().To<Rankine>();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Rankine
    }
}
