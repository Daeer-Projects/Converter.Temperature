using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000d, -1459.67d)]
    [InlineData(0d, -459.67d)]
    [InlineData(50d, -409.67d)]
    [InlineData(100d, -359.67d)]
    [InlineData(500d, 40.329999999999984d)]
    [InlineData(1000d, 540.3299999999999d)]
    public void Test_double_extension_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d)]
    [InlineData(0d, -459.67d)]
    [InlineData(50d, -409.67d)]
    [InlineData(100d, -359.67d)]
    [InlineData(500d, 40.329999999999984d)]
    [InlineData(1000d, 540.3299999999999d)]
    public void Test_double_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d, -1)]
    [InlineData(0d, -459.67d, -1)]
    [InlineData(50d, -409.67d, -1)]
    [InlineData(100d, -359.67d, -1)]
    [InlineData(500d, 40.329999999999984d, -1)]
    [InlineData(1000d, 540.3299999999999d, -1)]
    [InlineData(-1000d, -1460d, 0)]
    [InlineData(0d, -460d, 0)]
    [InlineData(50d, -410d, 0)]
    [InlineData(100d, -360d, 0)]
    [InlineData(500d, 40d, 0)]
    [InlineData(1000d, 540d, 0)]
    [InlineData(-1000d, -1459.7d, 1)]
    [InlineData(0d, -459.67d, 2)]
    [InlineData(50d, -409.7d, 1)]
    [InlineData(100d, -359.7d, 1)]
    [InlineData(500d, 40.32999999999998d, 14)]
    [InlineData(1000d, 540.33d, 2)]
    public void Test_double_extension_with_parameter_from_rankine_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -1459.67d, -1)]
    [InlineData(0d, -459.67d, -1)]
    [InlineData(50d, -409.67d, -1)]
    [InlineData(100d, -359.67d, -1)]
    [InlineData(500d, 40.329999999999984d, -1)]
    [InlineData(1000d, 540.3299999999999d, -1)]
    [InlineData(-1000d, -1460d, 0)]
    [InlineData(0d, -460d, 0)]
    [InlineData(50d, -410d, 0)]
    [InlineData(100d, -360d, 0)]
    [InlineData(500d, 40d, 0)]
    [InlineData(1000d, 540d, 0)]
    [InlineData(-1000d, -1459.7d, 1)]
    [InlineData(0d, -459.67d, 2)]
    [InlineData(50d, -409.7d, 1)]
    [InlineData(100d, -359.7d, 1)]
    [InlineData(500d, 40.32999999999998d, 14)]
    [InlineData(1000d, 540.33d, 2)]
    public void
        Test_double_extension_generic_with_parameter_from_rankine_and_to_fahrenheit_returns_correct_double_value(
            double value,
            double expected,
            int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
