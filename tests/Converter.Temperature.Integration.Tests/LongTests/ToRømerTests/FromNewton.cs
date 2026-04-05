using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33L, -45L)]
    [InlineData(0L, 8L)]
    [InlineData(33L, 60L)]
    [InlineData(-5797548137451573370L, long.MinValue)]
    [InlineData(5797548137451573359L, 9223372036854775806L)]
    public void Test_long_extensions_from_newton_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33L, -45L)]
    [InlineData(0L, 8L)]
    [InlineData(33L, 60L)]
    [InlineData(-5797548137451573370L, long.MinValue)]
    [InlineData(5797548137451573359L, 9223372036854775806L)]
    public void Test_long_extensions_generic_from_newton_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(5797548137451573361L)]
    public void Test_long_extensions_from_newton_to_rømer_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(5797548137451573361L)]
    public void Test_long_extensions_generic_from_newton_to_rømer_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
