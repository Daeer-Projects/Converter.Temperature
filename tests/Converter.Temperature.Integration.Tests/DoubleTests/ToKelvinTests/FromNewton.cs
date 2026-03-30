using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, 173.15d)]
    [InlineData(0d, 273.15d)]
    [InlineData(33d, 373.15d)]
    public void Test_double_extensions_from_newton_to_kelvin_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, 173.15d)]
    [InlineData(0d, 273.15d)]
    [InlineData(33d, 373.15d)]
    public void Test_double_extensions_generic_from_newton_to_kelvin_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
