using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_celsius_returns_correct_string_value(double value)
        {
            // Arrange.
            var stringValue = value.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = stringValue.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_fahrenheit_returns_correct_string_value(double value)
        {
            // Arrange.
            var stringValue = value.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = stringValue.FromFahrenheit().ToFahrenheit();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-345.65d)]
        [InlineData(0.0d)]
        [InlineData(7564.2334d)]
        [InlineData(double.MaxValue)]
        public void Test_string_extension_from_and_to_kelvin_returns_correct_string_value(double value)
        {
            // Arrange.
            var stringValue = value.ToString(CultureInfo.InvariantCulture);

            // Act.
            var result = stringValue.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value.ToString(CultureInfo.InvariantCulture));
        }
    }
}
