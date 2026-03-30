using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, -100d)]
    [InlineData(0d, 0d)]
    [InlineData(33d, 100d)]
    public void Test_double_extensions_from_newton_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, -100d)]
    [InlineData(0d, 0d)]
    [InlineData(33d, 100d)]
    public void Test_double_extensions_generic_from_newton_to_celsius_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
