﻿namespace Converter.Temperature.Integration.Tests.StringTests
{
    using System;
    using System.Globalization;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using TemperatureTypes;
    using Xunit;

    public class ToRankineStringTests
    {
        #region From Celsius

        [Fact]
        public void Test_string_extensions_from_celsius_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            const string input = "200";

            // Act.
            var result = input.FromCelsius().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_celsius_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            const string input = "200";

            // Act.
            var result = input.From<Celsius>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).FromCelsius().ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(double.MaxValue)]
        public void Test_string_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(double input)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToString(CultureInfo.InvariantCulture).From<Celsius>().To<Rankine>());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_string_extensions_from_fahrenheit_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6700000000001";
            const string input = "392";

            // Act.
            var result = input.FromFahrenheit().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6700000000001";
            const string input = "392";

            // Act.
            var result = input.From<Fahrenheit>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Theory]
        [InlineData(-1000d, -1800d)]
        [InlineData(0d, 0d)]
        [InlineData(50d, 90d)]
        [InlineData(1000d, 1800d)]
        public void Test_string_extension_from_kelvin_to_rankine_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromKelvin().ToRankine();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(-1000d, -1800d)]
        [InlineData(0d, 0d)]
        [InlineData(50d, 90d)]
        [InlineData(1000d, 1800d)]
        public void Test_string_extension_generic_from_kelvin_to_rankine_returns_correct_string_value(double value, double expected)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Kelvin>().To<Rankine>();

            // Assert.
            result.Should().Be(expected.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Kelvin

        #region From Gas

        [Fact]
        public void Test_string_extension_from_gas_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            const string input = "6";

            // Act.
            var result = input.FromGas().ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extension_generic_from_gas_to_rankine_returns_correct_value()
        {
            // Arrange.
            const string expected = "851.6699999999998";
            const string input = "6";

            // Act.
            var result = input.From<Gas>().To<Rankine>();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Gas

        #region From Rankine

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_rankine_returns_correct_double_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).FromRankine().ToRankine();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_generic_from_and_to_rankine_returns_correct_double_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.ToString(CultureInfo.InvariantCulture).From<Rankine>().To<Rankine>();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        #endregion From Rankine
    }
}
