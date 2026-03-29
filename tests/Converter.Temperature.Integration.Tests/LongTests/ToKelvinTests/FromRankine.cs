using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000L, -556L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 28L)]
    [InlineData(100L, 56L)]
    [InlineData(500L, 278L)]
    [InlineData(1000L, 556L)]
    public void Test_long_extension_from_rankine_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -556L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 28L)]
    [InlineData(100L, 56L)]
    [InlineData(500L, 278L)]
    [InlineData(1000L, 556L)]
    public void Test_long_extension_generic_from_rankine_and_to_kelvin_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
