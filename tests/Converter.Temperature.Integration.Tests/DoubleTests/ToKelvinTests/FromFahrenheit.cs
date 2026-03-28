using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToKelvinTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_double_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
