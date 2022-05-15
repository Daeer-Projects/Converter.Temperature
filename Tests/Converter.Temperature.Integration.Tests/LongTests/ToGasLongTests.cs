namespace Converter.Temperature.Integration.Tests.LongTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToGasLongTests
    {
        #region From Celsius

        [Fact]
        public void Test_long_extensions_from_celsius_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 200L;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_celsius_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 200L;

            // Act.
            var result = input.From<Celsius>().To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(135L, 1L)]
        [InlineData(144L, 1L)]
        [InlineData(145L, 2L)]
        [InlineData(154L, 2L)]
        [InlineData(155L, 3L)]
        [InlineData(174L, 3L)]
        [InlineData(175L, 4L)]
        [InlineData(184L, 4L)]
        [InlineData(185L, 5L)]
        [InlineData(194L, 5L)]
        [InlineData(195L, 6L)]
        [InlineData(209L, 6L)]
        [InlineData(210L, 7L)]
        [InlineData(224L, 7L)]
        [InlineData(225L, 8L)]
        [InlineData(234L, 8L)]
        [InlineData(235L, 9L)]
        [InlineData(244L, 9L)]
        [InlineData(245L, 10L)]
        [InlineData(269L, 10L)]
        public void Test_long_extensions_from_celsius_to_gas_returns_correct_gas_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(135L, 1L)]
        [InlineData(144L, 1L)]
        [InlineData(145L, 2L)]
        [InlineData(154L, 2L)]
        [InlineData(155L, 3L)]
        [InlineData(174L, 3L)]
        [InlineData(175L, 4L)]
        [InlineData(184L, 4L)]
        [InlineData(185L, 5L)]
        [InlineData(194L, 5L)]
        [InlineData(195L, 6L)]
        [InlineData(209L, 6L)]
        [InlineData(210L, 7L)]
        [InlineData(224L, 7L)]
        [InlineData(225L, 8L)]
        [InlineData(234L, 8L)]
        [InlineData(235L, 9L)]
        [InlineData(244L, 9L)]
        [InlineData(245L, 10L)]
        [InlineData(269L, 10L)]
        public void Test_long_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.From<Celsius>().To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const long input = 74536L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_long_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const long input = 74536L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>().To<Gas>());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Theory]
        [InlineData(134L, "Temp too low for gas mark!")]
        [InlineData(270L, "Temp too high for gas mark!")]
        public void Test_long_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(long input, string expectedError)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain(expectedError);
        }

        [Theory]
        [InlineData(134L, "Temp too low for gas mark!")]
        [InlineData(270L, "Temp too high for gas mark!")]
        public void Test_long_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(long input, string expectedError)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>().To<Gas>());

            // Assert.
            result.Message.Should().Contain(expectedError);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_long_extensions_from_fahrenheit_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 392L;

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_fahrenheit_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 392L;

            // Act.
            var result = input.From<Fahrenheit>().To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_long_extensions_from_kelvin_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 473L;

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_kelvin_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 6L;
            const long input = 473L;

            // Act.
            var result = input.From<Kelvin>().To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(1L)]
        [InlineData(3L)]
        [InlineData(5L)]
        [InlineData(8L)]
        [InlineData(10L)]
        public void Test_long_extension_from_and_to_gas_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(1L)]
        [InlineData(3L)]
        [InlineData(5L)]
        [InlineData(8L)]
        [InlineData(10L)]
        public void Test_long_extension_generic_from_and_to_gas_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.From<Gas>().To<Gas>();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(11L)]
        public void Test_long_extension_from_and_to_gas_throws_exception(long value)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => value.FromGas().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(11L)]
        public void Test_long_extension_generic_from_and_to_gas_throws_exception(long value)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => value.From<Gas>().To<Gas>());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas

        #region From Rankine

        [Fact]
        public void Test_long_extensions_from_rankine_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 4L;
            const long input = 807L;

            // Act.
            var result = input.FromRankine().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_rankine_to_gas_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 4L;
            const long input = 807L;

            // Act.
            var result = input.From<Rankine>().To<Gas>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
        {
            // Arrange.
            const long input = 405L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_long_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
        {
            // Arrange.
            const long input = 405L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>().To<Gas>());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_long_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
        {
            // Arrange.
            const long input = 1001L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Fact]
        public void Test_long_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
        {
            // Arrange.
            const long input = 1001L;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>().To<Gas>());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        #endregion From Rankine
    }
}
