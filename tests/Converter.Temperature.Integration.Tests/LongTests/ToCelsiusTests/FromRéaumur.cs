using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, -100L)]
    [InlineData(0L, 0L)]
    [InlineData(80L, 100L)]
    public void Test_long_extensions_from_réaumur_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, -100L)]
    [InlineData(0L, 0L)]
    [InlineData(80L, 100L)]
    public void Test_long_extensions_generic_from_réaumur_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
