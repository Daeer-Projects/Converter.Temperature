using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33L, -148L)]
    [InlineData(0L, 32L)]
    [InlineData(33L, 212L)]
    [InlineData(-1690951540090042237L, -9223372036854775806L)]
    [InlineData(1690951540090042225L, 9223372036854775805L)]
    public void Test_long_extensions_from_newton_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33L, -148L)]
    [InlineData(0L, 32L)]
    [InlineData(33L, 212L)]
    [InlineData(-1690951540090042237L, -9223372036854775806L)]
    [InlineData(1690951540090042225L, 9223372036854775805L)]
    public void Test_long_extensions_generic_from_newton_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1690951540090042226L)]
    public void Test_long_extensions_from_newton_to_fahrenheit_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(1690951540090042226L)]
    public void Test_long_extensions_generic_from_newton_to_fahrenheit_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
