using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromKelvin
{
    [Fact]
    public void Test_double_extensions_from_kelvin_to_celsius_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 1.0d;
        const double input = 274.15d;

        // Act.
        double result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_kelvin_to_celsius_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 1.0d;
        const double input = 274.15d;

        // Act.
        double result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_double_value()
    {
        // Arrange.
        const double expected = double.MinValue;
        const double input = double.MinValue;

        // Act.
        double result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_double_value()
    {
        // Arrange.
        const double expected = double.MinValue;
        const double input = double.MinValue;

        // Act.
        double result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
