using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromRømer
{
    [Theory]
    [InlineData(0L, -14L)]
    [InlineData(50L, 81L)]
    [InlineData(100L, 176L)]
    [InlineData(500L, 938L)]
    [InlineData(1000L, 1890L)]
    public void Test_long_extension_from_rømer_and_to_celsius_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0L, -14L)]
    [InlineData(50L, 81L)]
    [InlineData(100L, 176L)]
    [InlineData(500L, 938L)]
    [InlineData(1000L, 1890L)]
    public void Test_long_extension_generic_from_rømer_and_to_celsius_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
