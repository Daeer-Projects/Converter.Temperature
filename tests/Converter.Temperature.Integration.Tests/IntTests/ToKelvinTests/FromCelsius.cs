using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromCelsius
{
    [Theory]
    [InlineData(200, 473)]
    [InlineData(2147483374, 2147483647)]
    [InlineData(-2147483648, -2147483375)]
    public void Test_int_extensions_from_celsius_to_kelvin_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(200, 473)]
    [InlineData(2147483374, 2147483647)]
    [InlineData(-2147483648, -2147483375)]
    public void Test_int_extensions_generic_from_celsius_to_kelvin_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2147483375)]
    public void Test_int_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(2147483375)]
    public void Test_int_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
