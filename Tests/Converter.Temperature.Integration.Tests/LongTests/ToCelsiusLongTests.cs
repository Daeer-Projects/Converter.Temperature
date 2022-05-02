﻿namespace Converter.Temperature.Integration.Tests.LongTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToCelsiusLongTests
    {
        #region From Celsius

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(-345L)]
        [InlineData(0L)]
        [InlineData(7564L)]
        [InlineData(long.MaxValue)]
        public void Test_long_extension_from_and_to_celsius_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(-345L)]
        [InlineData(0L)]
        [InlineData(7564L)]
        [InlineData(long.MaxValue)]
        public void Test_long_extension_generic_from_and_to_celsius_returns_correct_long_value(long value)
        {
            // Arrange.
            // Act.
            var result = value.From<Celsius>().To<Celsius>();

            // Assert.
            result.Should().Be(value);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Theory]
        [InlineData(50L, 10L)]
        [InlineData(long.MinValue, -9223372036854775808L)]
        [InlineData(long.MaxValue, 9223372036854775807L)]
        public void Test_long_extensions_from_fahrenheit_to_celsius_returns_correct_long_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.FromFahrenheit().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(50L, 10L)]
        [InlineData(long.MinValue, -9223372036854775808L)]
        [InlineData(long.MaxValue, 9223372036854775807L)]
        public void Test_long_extensions_generic_from_fahrenheit_to_celsius_returns_correct_long_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.From<Fahrenheit>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_long_extensions_from_kelvin_to_celsius_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 1L;
            const long input = 274L;

            // Act.
            var result = input.FromKelvin().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extensions_generic_from_kelvin_to_celsius_returns_correct_long_value()
        {
            // Arrange.
            const long expected = 1L;
            const long input = 274L;

            // Act.
            var result = input.From<Kelvin>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_long_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
        {
            // Arrange.
            const long input = long.MinValue;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_long_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
        {
            // Arrange.
            const long input = long.MinValue;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>().To<Celsius>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(1L, 140L)]
        [InlineData(2L, 150L)]
        [InlineData(3L, 165L)]
        [InlineData(4L, 180L)]
        [InlineData(5L, 190L)]
        [InlineData(6L, 200L)]
        [InlineData(7L, 220L)]
        [InlineData(8L, 230L)]
        [InlineData(9L, 240L)]
        [InlineData(10L, 260L)]
        public void Test_long_extensions_from_gas_to_celsius_returns_correct_long_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.FromGas().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1L, 140L)]
        [InlineData(2L, 150L)]
        [InlineData(3L, 165L)]
        [InlineData(4L, 180L)]
        [InlineData(5L, 190L)]
        [InlineData(6L, 200L)]
        [InlineData(7L, 220L)]
        [InlineData(8L, 230L)]
        [InlineData(9L, 240L)]
        [InlineData(10L, 260L)]
        public void Test_long_extensions_generic_from_gas_to_celsius_returns_correct_long_value(long input, long expected)
        {
            // Arrange.
            // Act.
            var result = input.From<Gas>().To<Celsius>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(11L)]
        public void Test_long_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(long input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas().ToCelsius());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        [Theory]
        [InlineData(0L)]
        [InlineData(11L)]
        public void Test_long_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(long input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>().To<Celsius>());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
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