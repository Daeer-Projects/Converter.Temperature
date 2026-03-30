using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80f, -148f)]
    [InlineData(0f, 32f)]
    [InlineData(80f, 212f)]
    public void Test_float_extensions_from_réaumur_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRéaumur()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-80f, -148f)]
    [InlineData(0f, 32f)]
    [InlineData(80f, 212f)]
    public void Test_float_extensions_generic_from_réaumur_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Réaumur>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
