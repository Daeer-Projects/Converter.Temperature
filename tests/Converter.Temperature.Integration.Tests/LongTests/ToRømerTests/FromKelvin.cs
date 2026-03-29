using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000L, -661L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -110L)]
    [InlineData(1000L, 389L)]
    public void Test_long_extension_from_kelvin_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -661L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -110L)]
    [InlineData(1000L, 389L)]
    public void Test_long_extension_generic_from_kelvin_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
