using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000L, -3422L)]
    [InlineData(0L, 6L)]
    [InlineData(50L, 178L)]
    [InlineData(100L, 349L)]
    [InlineData(500L, 1721L)]
    [InlineData(1000L, 3435L)]
    public void Test_long_extension_from_rømer_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -3422L)]
    [InlineData(0L, 6L)]
    [InlineData(50L, 178L)]
    [InlineData(100L, 349L)]
    [InlineData(500L, 1721L)]
    [InlineData(1000L, 3435L)]
    public void Test_long_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
