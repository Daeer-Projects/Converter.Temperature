using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromCelsius
{
    [Fact]
    public void Test_long_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        const long input = 200L;

        // Act.
        long result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        const long input = 200L;

        // Act.
        long result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
