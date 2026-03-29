using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    public void Test_long_extension_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1460L)]
    [InlineData(0L, -460L)]
    [InlineData(50L, -410L)]
    [InlineData(100L, -360L)]
    [InlineData(500L, 40L)]
    [InlineData(1000L, 540L)]
    public void Test_long_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
