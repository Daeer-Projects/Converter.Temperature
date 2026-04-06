using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromRømer
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4842270319348757436L)]
    [InlineData(4842270319348757164L)]
    public void Test_long_extension_from_rømer_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4842270319348757436L)]
    [InlineData(4842270319348757164L)]
    public void Test_long_extension_generic_from_rømer_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1000L, -1646L)]
    [InlineData(0L, 259L)]
    [InlineData(50L, 354L)]
    [InlineData(100L, 449L)]
    [InlineData(500L, 1211L)]
    [InlineData(1000L, 2164L)]
    [InlineData(-4842270319348757435L, -9223372036854775808L)]
    [InlineData(4842270319348757163L, 9223372036854775807L)]
    public void Test_long_extension_from_rømer_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1646L)]
    [InlineData(0L, 259L)]
    [InlineData(50L, 354L)]
    [InlineData(100L, 449L)]
    [InlineData(500L, 1211L)]
    [InlineData(1000L, 2164L)]
    [InlineData(-4842270319348757435L, -9223372036854775808L)]
    [InlineData(4842270319348757163L, 9223372036854775807L)]
    public void Test_long_extension_generic_from_rømer_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
