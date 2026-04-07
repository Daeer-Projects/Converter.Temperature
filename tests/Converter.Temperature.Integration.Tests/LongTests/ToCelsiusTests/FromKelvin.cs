using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromKelvin
{
    [Fact]
    public void Test_long_extensions_from_kelvin_to_celsius_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 1L;
        const long input = 274L;

        // Act.
        long result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_kelvin_to_celsius_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 1L;
        const long input = 274L;

        // Act.
        long result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-9223372036854775536L)]
    public void Test_long_extension_from_kelvin_and_to_celsius_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-9223372036854775536L)]
    public void
        Test_long_extension_generic_from_kelvin_and_to_celsius_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-9223372036854775535L, -9223372036854775808L)]
    [InlineData(-9223372036854775534L, -9223372036854775807L)]
    public void Test_long_extension_from_kelvin_and_to_celsius_with_boundary_values_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-9223372036854775535L, -9223372036854775808L)]
    [InlineData(-9223372036854775534L, -9223372036854775807L)]
    public void
        Test_long_extension_generic_from_kelvin_and_to_celsius_with_boundary_values_returns_correct_long_value(
            long input,
            long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
