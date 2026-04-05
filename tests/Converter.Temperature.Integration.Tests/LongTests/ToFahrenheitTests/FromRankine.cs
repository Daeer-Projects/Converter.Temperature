using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    [InlineData(-9223372036854775348L, -9223372036854775808L)]
    public void Test_long_extension_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    [InlineData(-9223372036854775348L, -9223372036854775808L)]
    public void Test_long_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-9223372036854775349L)]
    public void Test_long_extensions_from_rankine_to_fahrenheit_with_invalid_parameter_throws_exception(
        long input)
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
    [InlineData(long.MinValue)]
    [InlineData(-9223372036854775349L)]
    public void Test_long_extensions_generic_from_rankine_to_fahrenheit_with_invalid_parameter_throws_exception(
        long input)
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
