using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300L, -148L)]
    [InlineData(150L, 32L)]
    [InlineData(0L, 212L)]
    public void Test_long_extensions_from_delisle_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300L, -148L)]
    [InlineData(150L, 32L)]
    [InlineData(0L, 212L)]
    public void Test_long_extensions_generic_from_delisle_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
