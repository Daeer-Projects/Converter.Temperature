using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33f, -100f)]
    [InlineData(0f, 0f)]
    [InlineData(33f, 100f)]
    public void Test_float_extensions_from_newton_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromNewton()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-33f, -100f)]
    [InlineData(0f, 0f)]
    [InlineData(33f, 100f)]
    public void Test_float_extensions_generic_from_newton_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Newton>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
