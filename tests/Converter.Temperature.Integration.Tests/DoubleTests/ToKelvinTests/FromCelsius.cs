using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToKelvinTests;

public class FromCelsius
{
    [Fact]
    public void Test_double_extensions_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.FromCelsius()
            .ToKelvin();
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_generic_from_celsius_to_kelvin_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.From<Celsius>()
            .To<Kelvin>();
    }
}
