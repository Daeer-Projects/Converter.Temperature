using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(80L, 672L)]
    public void Test_long_extensions_from_réaumur_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(80L, 672L)]
    public void Test_long_extensions_generic_from_réaumur_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4099276460824345023L)]
    [InlineData(4099276460824344585L)]
    public void Test_long_extension_from_réaumur_to_rankine_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4099276460824345023L)]
    [InlineData(4099276460824344585L)]
    public void Test_long_extension_generic_from_réaumur_to_rankine_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-4099276460824345022L, -9223372036854775808L)]
    [InlineData(4099276460824344584L, 9223372036854775806L)]
    public void Test_long_extension_from_réaumur_to_rankine_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-4099276460824345022L, -9223372036854775808L)]
    [InlineData(4099276460824344584L, 9223372036854775806L)]
    public void Test_long_extension_generic_from_réaumur_to_rankine_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
