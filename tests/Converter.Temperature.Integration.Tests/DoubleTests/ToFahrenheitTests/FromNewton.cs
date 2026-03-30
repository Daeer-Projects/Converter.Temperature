using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, -148d)]
    [InlineData(0d, 32d)]
    [InlineData(33d, 212d)]
    public void Test_double_extensions_from_newton_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, -148d)]
    [InlineData(0d, 32d)]
    [InlineData(33d, 212d)]
    public void Test_double_extensions_generic_from_newton_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
