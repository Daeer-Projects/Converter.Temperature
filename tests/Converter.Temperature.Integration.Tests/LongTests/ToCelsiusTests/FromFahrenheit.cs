using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(50L, 10L)]
    [InlineData(long.MinValue, -5124095576030431232L)]
    [InlineData(long.MaxValue, 5124095576030431232L)]
    public void Test_long_extensions_from_fahrenheit_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50L, 10L)]
    [InlineData(long.MinValue, -5124095576030431232L)]
    [InlineData(long.MaxValue, 5124095576030431232L)]
    public void Test_long_extensions_generic_from_fahrenheit_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
