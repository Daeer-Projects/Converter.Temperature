using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromKelvin
{
    [Theory]
    [InlineData(273L, 150L)]
    [InlineData(373L, 0L)]
    [InlineData(6148914691236517578L, -9223372036854775807L)]
    [InlineData(-6148914691236516831L, 9223372036854775806L)]
    public void Test_long_extension_from_kelvin_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(273L, 150L)]
    [InlineData(373L, 0L)]
    [InlineData(6148914691236517578L, -9223372036854775807L)]
    [InlineData(-6148914691236516831L, 9223372036854775806L)]
    public void Test_long_extension_generic_from_kelvin_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Kelvin>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(6148914691236517579L)]
    [InlineData(-6148914691236516832L)]
    public void Test_long_extension_from_kelvin_to_delisle_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin()
            .ToDelisle());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(6148914691236517579L)]
    [InlineData(-6148914691236516832L)]
    public void Test_long_extension_generic_from_kelvin_to_delisle_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>()
            .To<Delisle>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
