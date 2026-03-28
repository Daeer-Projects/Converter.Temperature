using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromRømer
{
        [Theory]
    [InlineData(-1000d, -3422.285714285714d)]
    [InlineData(0d, 6.285714285714285d)]
    [InlineData(50d, 177.71428571428572d)]
    [InlineData(100d, 349.14285714285717d)]
    [InlineData(500d, 1720.5714285714287d)]
    [InlineData(1000d, 3434.8571428571427d)]
    public void Test_double_extension_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -3422.285714285714d)]
    [InlineData(0d, 6.285714285714285d)]
    [InlineData(50d, 177.71428571428572d)]
    [InlineData(100d, 349.14285714285717d)]
    [InlineData(500d, 1720.5714285714287d)]
    [InlineData(1000d, 3434.8571428571427d)]
    public void Test_double_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -3422.285714285714d, -1)]
    [InlineData(0d, 6.285714285714285d, -1)]
    [InlineData(50d, 177.71428571428572d, -1)]
    [InlineData(100d, 349.14285714285717d, -1)]
    [InlineData(500d, 1720.5714285714287d, -1)]
    [InlineData(1000d, 3434.8571428571427d, -1)]
    [InlineData(-1000d, -3422d, 0)]
    [InlineData(0d, 6d, 0)]
    [InlineData(50d, 178d, 0)]
    [InlineData(100d, 349d, 0)]
    [InlineData(500d, 1721d, 0)]
    [InlineData(1000d, 3435d, 0)]
    [InlineData(-1000d, -3422.3d, 1)]
    [InlineData(0d, 6.29d, 2)]
    [InlineData(50d, 177.7d, 1)]
    [InlineData(100d, 349.1d, 1)]
    [InlineData(500d, 1720.571428571429d, 14)]
    [InlineData(1000d, 3434.86d, 2)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -3422.285714285714d, -1)]
    [InlineData(0d, 6.285714285714285d, -1)]
    [InlineData(50d, 177.71428571428572d, -1)]
    [InlineData(100d, 349.14285714285717d, -1)]
    [InlineData(500d, 1720.5714285714287d, -1)]
    [InlineData(1000d, 3434.8571428571427d, -1)]
    [InlineData(-1000d, -3422d, 0)]
    [InlineData(0d, 6d, 0)]
    [InlineData(50d, 178d, 0)]
    [InlineData(100d, 349d, 0)]
    [InlineData(500d, 1721d, 0)]
    [InlineData(1000d, 3435d, 0)]
    [InlineData(-1000d, -3422.3d, 1)]
    [InlineData(0d, 6.29d, 2)]
    [InlineData(50d, 177.7d, 1)]
    [InlineData(100d, 349.1d, 1)]
    [InlineData(500d, 1720.571428571429d, 14)]
    [InlineData(1000d, 3434.86d, 2)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
