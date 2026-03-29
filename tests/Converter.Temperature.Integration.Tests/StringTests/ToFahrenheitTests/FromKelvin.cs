using System;
using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromKelvin
{
    [Fact]
    public void Test_string_extensions_from_kelvin_to_fahrenheit_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "33.799999999999955";
        const string input = "274.15";

        // Act.
        string result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "33.799999999999955";
        const string input = "274.15";

        // Act.
        string result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        Action action = () => input
            .ToString(CultureInfo.InvariantCulture)
            .FromKelvin()
            .ToFahrenheit();

        // Assert.
        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_generic_from_kelvin_to_fahrenheit_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        Action action = () => input
            .ToString(CultureInfo.InvariantCulture)
            .From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }
}
