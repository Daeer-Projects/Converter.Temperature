using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromRømer
{
    [Theory]
    [InlineData(7L, -1L)]
    [InlineData(60L, 80L)]
    [InlineData(-6052837899185946616L, -9223372036854775807L)]
    [InlineData(6052837899185946631L, 9223372036854775807L)]
    public void Test_long_extension_from_rømer_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(7L, -1L)]
    [InlineData(60L, 80L)]
    [InlineData(-6052837899185946616L, -9223372036854775807L)]
    [InlineData(6052837899185946631L, 9223372036854775807L)]
    public void Test_long_extension_generic_from_rømer_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.

        // Act.
        long result = input.From<Rømer>().To<Réaumur>();

        // Assert.
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-6052837899185946617L)]
    [InlineData(6052837899185946632L)]
    public void Test_long_extension_from_rømer_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToRéaumur());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-6052837899185946617L)]
    [InlineData(6052837899185946632L)]
    public void Test_long_extension_generic_from_rømer_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Réaumur>());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }
}
