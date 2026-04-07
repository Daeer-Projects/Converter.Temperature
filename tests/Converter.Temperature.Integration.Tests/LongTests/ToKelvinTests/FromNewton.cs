using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(33L, 373L)]
    [InlineData(-3043712772162076106L, -9223372036854775806L)]
    [InlineData(3043712772162075926L, 9223372036854775806L)]
    public void Test_long_extensions_from_newton_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(33L, 373L)]
    [InlineData(-3043712772162076106L, -9223372036854775806L)]
    [InlineData(3043712772162075926L, 9223372036854775806L)]
    public void Test_long_extensions_generic_from_newton_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(3043712772162075927L)]
    public void Test_long_extensions_from_newton_to_kelvin_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(3043712772162075927L)]
    public void Test_long_extensions_generic_from_newton_to_kelvin_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
