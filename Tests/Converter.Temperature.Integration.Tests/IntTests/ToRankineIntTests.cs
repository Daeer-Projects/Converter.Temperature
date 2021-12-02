namespace Converter.Temperature.Integration.Tests.IntTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using Xunit;

    public class ToRankineIntTests
    {
        #region From Celsius

        [Fact]
        public void Test_int_extensions_from_celsius_to_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = 852;
            var input = 200;

            // Act.
            var result = input.FromCelsius().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void Test_int_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(int input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_int_extensions_from_fahrenheit_to_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = 852;
            var input = 392;

            // Act.
            var result = input.FromFahrenheit().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(-1000, -1800)]
        [InlineData(0, 0)]
        [InlineData(50, 90)]
        [InlineData(1000, 1800)]
        public void Test_int_extension_from_kelvin_to_rankine_returns_correct_int_value(int value, int expected)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_int_extension_from_gas_to_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = 852;
            var input = 6;

            // Act.
            var result = input.FromGas().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0)]
        [InlineData(7564)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_rankine_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromRankine().ToRankine();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Rankine
    }
}
