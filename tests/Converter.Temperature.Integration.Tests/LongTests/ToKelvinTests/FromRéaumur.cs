using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(80L, 373L)]
    public void Test_long_extensions_from_réaumur_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 173L)]
    [InlineData(0L, 273L)]
    [InlineData(80L, 373L)]
    public void Test_long_extensions_generic_from_réaumur_to_kelvin_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
