using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 300L)]
    [InlineData(0L, 150L)]
    [InlineData(80L, 0L)]
    public void Test_long_extensions_from_réaumur_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 300L)]
    [InlineData(0L, 150L)]
    [InlineData(80L, 0L)]
    public void Test_long_extensions_generic_from_réaumur_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4919131752989213685L)]
    [InlineData(4919131752989213845L)]
    public void Test_long_extension_from_réaumur_to_delisle_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToDelisle());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4919131752989213685L)]
    [InlineData(4919131752989213845L)]
    public void Test_long_extension_generic_from_réaumur_to_delisle_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Delisle>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-4919131752989213683L, 9223372036854775806L)]
    [InlineData(4919131752989213844L, -9223372036854775808L)]
    public void Test_long_extension_from_réaumur_to_delisle_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-4919131752989213683L, 9223372036854775806L)]
    [InlineData(4919131752989213844L, -9223372036854775808L)]
    public void Test_long_extension_generic_from_réaumur_to_delisle_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
