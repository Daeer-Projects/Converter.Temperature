using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromCelsius
{
    [Fact]
    public void Test_long_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 200L;

        // Act.
        long result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 200L;

        // Act.
        long result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        const long input = long.MaxValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        const long input = long.MaxValue;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
