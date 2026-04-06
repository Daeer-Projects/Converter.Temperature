using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromRømer
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-2690150177415976280L)]
    [InlineData(2690150177415976276L)]
    public void Test_long_extension_from_rømer_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-2690150177415976280L)]
    [InlineData(2690150177415976276L)]
    public void
        Test_long_extension_generic_from_rømer_and_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1000L, -3422L)]
    [InlineData(0L, 6L)]
    [InlineData(50L, 178L)]
    [InlineData(100L, 349L)]
    [InlineData(500L, 1721L)]
    [InlineData(1000L, 3435L)]
    [InlineData(-2690150177415976279L, -9223372036854775807L)]
    [InlineData(2690150177415976275L, 9223372036854775806L)]
    public void Test_long_extension_from_rømer_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -3422L)]
    [InlineData(0L, 6L)]
    [InlineData(50L, 178L)]
    [InlineData(100L, 349L)]
    [InlineData(500L, 1721L)]
    [InlineData(1000L, 3435L)]
    [InlineData(-2690150177415976279L, -9223372036854775807L)]
    [InlineData(2690150177415976275L, 9223372036854775806L)]
    public void Test_long_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
