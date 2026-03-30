using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33f, 173.149993896484f)]
    [InlineData(0f, 273.149993896484f)]
    [InlineData(33f, 373.149993896484f)]
    public void Test_float_extensions_from_newton_to_kelvin_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-33f, 173.149993896484f)]
    [InlineData(0f, 273.149993896484f)]
    [InlineData(33f, 373.149993896484f)]
    public void Test_float_extensions_generic_from_newton_to_kelvin_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
