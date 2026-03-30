using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300d, -148d)]
    [InlineData(150d, 32d)]
    [InlineData(0d, 212d)]
    public void Test_double_extensions_from_delisle_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(300d, -148d)]
    [InlineData(150d, 32d)]
    [InlineData(0d, 212d)]
    public void Test_double_extensions_generic_from_delisle_to_fahrenheit_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
