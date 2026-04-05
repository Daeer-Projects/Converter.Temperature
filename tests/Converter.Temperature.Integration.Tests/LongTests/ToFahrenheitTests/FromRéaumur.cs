using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, -148L)]
    [InlineData(0L, 32L)]
    [InlineData(80L, 212L)]
    public void Test_long_extensions_from_réaumur_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, -148L)]
    [InlineData(0L, 32L)]
    [InlineData(80L, 212L)]
    public void Test_long_extensions_generic_from_réaumur_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4099276460824344819L)]
    [InlineData(4099276460824344790L)]
    public void Test_long_extension_from_réaumur_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-4099276460824344819L)]
    [InlineData(4099276460824344790L)]
    public void Test_long_extension_generic_from_réaumur_to_fahrenheit_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-4099276460824344817L, -9223372036854775806L)]
    [InlineData(4099276460824344789L, 9223372036854775807L)]
    public void Test_long_extension_from_réaumur_to_fahrenheit_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-4099276460824344817L, -9223372036854775806L)]
    [InlineData(4099276460824344789L, 9223372036854775807L)]
    public void Test_long_extension_generic_from_réaumur_to_fahrenheit_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
