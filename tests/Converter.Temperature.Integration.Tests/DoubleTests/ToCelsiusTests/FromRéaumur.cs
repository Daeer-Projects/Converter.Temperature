using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80d, -100d)]
    [InlineData(0d, 0d)]
    [InlineData(80d, 100d)]
    public void Test_double_extensions_from_réaumur_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-80d, -100d)]
    [InlineData(0d, 0d)]
    [InlineData(80d, 100d)]
    public void Test_double_extensions_generic_from_réaumur_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Réaumur>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
