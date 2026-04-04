using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000L, -1800L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 90L)]
    [InlineData(1000L, 1800L)]
    [InlineData(5124095576030431004L, 9223372036854775807L)]
    [InlineData(-5124095576030431004L, -9223372036854775807L)]
    public void Test_long_extension_from_kelvin_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1800L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 90L)]
    [InlineData(1000L, 1800L)]
    [InlineData(5124095576030431004L, 9223372036854775807L)]
    [InlineData(-5124095576030431004L, -9223372036854775807L)]
    public void Test_long_extension_generic_from_kelvin_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(5124095576030431005L)]
    [InlineData(-5124095576030431005L)]
    public void Test_long_extensions_from_kelvin_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(5124095576030431005L)]
    [InlineData(-5124095576030431005L)]
    public void Test_long_extensions_generic_from_kelvin_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
