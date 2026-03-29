using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_double_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6700000000001d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6700000000001d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.6700000000001d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.6700000000001d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_generic_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
