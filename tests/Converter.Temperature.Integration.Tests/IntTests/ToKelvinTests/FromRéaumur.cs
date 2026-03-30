using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, 173)]
    [InlineData(0, 273)]
    [InlineData(80, 373)]
    public void Test_int_extensions_from_réaumur_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, 173)]
    [InlineData(0, 273)]
    [InlineData(80, 373)]
    public void Test_int_extensions_generic_from_réaumur_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
