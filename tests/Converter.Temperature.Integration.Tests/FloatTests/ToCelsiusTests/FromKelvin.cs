using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromKelvin
{
    [Fact]
    public void Test_float_extensions_from_kelvin_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 1.0189514f;
        const float input = 274.168932972f;

        // Act.
        float result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_kelvin_to_celsius_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 1.0189514f;
        const float input = 274.168932972f;

        // Act.
        float result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_float_value()
    {
        // Arrange.
        const float expected = float.MinValue;
        const float input = float.MinValue;

        // Act.
        float result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_float_value()
    {
        // Arrange.
        const float expected = float.MinValue;
        const float input = float.MinValue;

        // Act.
        float result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
