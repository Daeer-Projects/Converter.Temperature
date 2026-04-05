using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(80L, 373L)]
    public void Test_long_extensions_from_réaumur_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(80L, 373L)]
    public void Test_long_extensions_generic_from_réaumur_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-7378697629483820866L)]
    [InlineData(7378697629483820428L)]
    public void Test_long_extension_from_réaumur_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-7378697629483820866L)]
    [InlineData(7378697629483820428L)]
    public void Test_long_extension_generic_from_réaumur_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-7378697629483820865L, -9223372036854775808L)]
    [InlineData(7378697629483820427L, 9223372036854775807L)]
    public void Test_long_extension_from_réaumur_to_kelvin_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-7378697629483820865L, -9223372036854775808L)]
    [InlineData(7378697629483820427L, 9223372036854775807L)]
    public void Test_long_extension_generic_from_réaumur_to_kelvin_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
