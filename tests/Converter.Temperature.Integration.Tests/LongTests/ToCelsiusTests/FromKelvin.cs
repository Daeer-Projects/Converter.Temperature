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

    [Fact]
    public void Test_long_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
    {
        // Arrange.
        const long expected = long.MinValue;
        const long input = long.MinValue;

        // Act.
        long result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_long_value()
    {
        // Arrange.
        const long expected = long.MinValue;
        const long input = long.MinValue;

        // Act.
        long result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
