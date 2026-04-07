using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000, -1460)]
    [InlineData(0, -460)]
    [InlineData(50, -410)]
    [InlineData(100, -360)]
    [InlineData(500, 40)]
    [InlineData(1000, 540)]
    [InlineData(-2147483188, -2147483648)]
    public void Test_int_extension_from_rankine_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1460)]
    [InlineData(0, -460)]
    [InlineData(50, -410)]
    [InlineData(100, -360)]
    [InlineData(500, 40)]
    [InlineData(1000, 540)]
    [InlineData(-2147483188, -2147483648)]
    public void Test_int_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-2147483189)]
    public void Test_int_extensions_from_rankine_to_fahrenheit_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-2147483189)]
    public void Test_int_extensions_generic_from_rankine_to_fahrenheit_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
