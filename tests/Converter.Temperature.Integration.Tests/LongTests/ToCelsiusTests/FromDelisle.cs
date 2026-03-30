using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300L, -100L)]
    [InlineData(150L, 0L)]
    [InlineData(0L, 100L)]
    public void Test_long_extensions_from_delisle_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300L, -100L)]
    [InlineData(150L, 0L)]
    [InlineData(0L, 100L)]
    public void Test_long_extensions_generic_from_delisle_to_celsius_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Delisle>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
