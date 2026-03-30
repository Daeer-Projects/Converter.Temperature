using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromKelvin
{
    [Theory]
    [InlineData(173L, -80L)]
    [InlineData(273L, -0L)]
    [InlineData(373L, 80L)]
    public void Test_long_extensions_from_kelvin_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromKelvin()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(173L, -80L)]
    [InlineData(273L, -0L)]
    [InlineData(373L, 80L)]
    public void Test_long_extensions_generic_from_kelvin_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Kelvin>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
