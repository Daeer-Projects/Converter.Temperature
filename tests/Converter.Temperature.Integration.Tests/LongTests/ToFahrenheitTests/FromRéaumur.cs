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
}
