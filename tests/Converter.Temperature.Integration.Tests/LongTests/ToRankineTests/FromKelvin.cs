using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000L, -1800L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 90L)]
    [InlineData(1000L, 1800L)]
    public void Test_long_extension_from_kelvin_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -1800L)]
    [InlineData(0L, 0L)]
    [InlineData(50L, 90L)]
    [InlineData(1000L, 1800L)]
    public void Test_long_extension_generic_from_kelvin_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
