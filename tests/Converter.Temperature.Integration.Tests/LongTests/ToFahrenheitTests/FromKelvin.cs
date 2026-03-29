using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromKelvin
{
    [Fact]
    public void Test_long_extensions_from_kelvin_to_fahrenheit_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 34L;
        const long input = 274L;

        // Act.
        long result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 34L;
        const long input = 274L;

        // Act.
        long result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_long_value(
        long input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.FromKelvin()
            .ToFahrenheit();
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_generic_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_long_value(
        long input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.From<Kelvin>()
            .To<Fahrenheit>();
    }
}
