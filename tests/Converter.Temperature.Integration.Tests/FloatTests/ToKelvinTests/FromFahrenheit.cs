using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToKelvinTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 392f;

        // Act.
        float result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        const float input = 392f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
