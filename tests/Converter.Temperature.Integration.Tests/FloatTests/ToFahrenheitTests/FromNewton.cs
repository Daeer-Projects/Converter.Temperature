using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33f, -148f)]
    [InlineData(0f, 32f)]
    [InlineData(33f, 212f)]
    public void Test_float_extensions_from_newton_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromNewton()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-33f, -148f)]
    [InlineData(0f, 32f)]
    [InlineData(33f, 212f)]
    public void Test_float_extensions_generic_from_newton_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Newton>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
