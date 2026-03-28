using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromRømer
{
    [Theory]
    [InlineData(0d, -14.285714285714286d)]
    [InlineData(50d, 80.95238095238095d)]
    [InlineData(100d, 176.1904761904762d)]
    [InlineData(500d, 938.0952380952381d)]
    [InlineData(1000d, 1890.4761904761904d)]
    public void Test_double_extension_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d)]
    [InlineData(50d, 80.95238095238095d)]
    [InlineData(100d, 176.1904761904762d)]
    [InlineData(500d, 938.0952380952381d)]
    [InlineData(1000d, 1890.4761904761904d)]
    public void Test_double_extension_generic_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d, -1)]
    [InlineData(50d, 80.95238095238095d, -1)]
    [InlineData(100d, 176.1904761904762d, -1)]
    [InlineData(500d, 938.0952380952381d, -1)]
    [InlineData(1000d, 1890.4761904761904d, -1)]
    [InlineData(0d, -14d, 0)]
    [InlineData(50d, 81d, 0)]
    [InlineData(100d, 176d, 0)]
    [InlineData(500d, 938d, 0)]
    [InlineData(1000d, 1890d, 0)]
    [InlineData(0d, -14.3d, 1)]
    [InlineData(50d, 80.95d, 2)]
    [InlineData(100d, 176.2d, 1)]
    [InlineData(500d, 938.0952380952381d, 14)]
    [InlineData(1000d, 1890.48d, 2)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d, -1)]
    [InlineData(50d, 80.95238095238095d, -1)]
    [InlineData(100d, 176.1904761904762d, -1)]
    [InlineData(500d, 938.0952380952381d, -1)]
    [InlineData(1000d, 1890.4761904761904d, -1)]
    [InlineData(0d, -14d, 0)]
    [InlineData(50d, 81d, 0)]
    [InlineData(100d, 176d, 0)]
    [InlineData(500d, 938d, 0)]
    [InlineData(1000d, 1890d, 0)]
    [InlineData(0d, -14.3d, 1)]
    [InlineData(50d, 80.95d, 2)]
    [InlineData(100d, 176.2d, 1)]
    [InlineData(500d, 938.0952380952381d, 14)]
    [InlineData(1000d, 1890.48d, 2)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
