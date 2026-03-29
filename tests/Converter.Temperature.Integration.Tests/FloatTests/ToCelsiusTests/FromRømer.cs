using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromRømer
{
    [Theory]
    [InlineData(0f, -14.285714285714286f)]
    [InlineData(50f, 80.95238095238095f)]
    [InlineData(100f, 176.1904761904762f)]
    [InlineData(500f, 938.0952380952381f)]
    [InlineData(1000f, 1890.4761904761904f)]
    public void Test_float_extension_from_rømer_and_to_celsius_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -14.285714285714286f)]
    [InlineData(50f, 80.95238095238095f)]
    [InlineData(100f, 176.1904761904762f)]
    [InlineData(500f, 938.0952380952381f)]
    [InlineData(1000f, 1890.4761904761904f)]
    public void Test_float_extension_generic_from_rømer_and_to_celsius_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -14.285714285714286f, -1)]
    [InlineData(50f, 80.95238095238095f, -1)]
    [InlineData(100f, 176.1904761904762f, -1)]
    [InlineData(500f, 938.0952380952381f, -1)]
    [InlineData(1000f, 1890.4761904761904f, -1)]
    [InlineData(0f, -14f, 0)]
    [InlineData(50f, 81f, 0)]
    [InlineData(100f, 176f, 0)]
    [InlineData(500f, 938f, 0)]
    [InlineData(1000f, 1890f, 0)]
    [InlineData(0f, -14.3f, 1)]
    [InlineData(50f, 80.95f, 2)]
    [InlineData(100f, 176.2f, 1)]
    [InlineData(500f, 938.0952380952381f, 14)]
    [InlineData(1000f, 1890.48f, 2)]
    public void Test_float_extension_with_parameter_from_rømer_and_to_celsius_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0f, -14.285714285714286f, -1)]
    [InlineData(50f, 80.95238095238095f, -1)]
    [InlineData(100f, 176.1904761904762f, -1)]
    [InlineData(500f, 938.0952380952381f, -1)]
    [InlineData(1000f, 1890.4761904761904f, -1)]
    [InlineData(0f, -14f, 0)]
    [InlineData(50f, 81f, 0)]
    [InlineData(100f, 176f, 0)]
    [InlineData(500f, 938f, 0)]
    [InlineData(1000f, 1890f, 0)]
    [InlineData(0f, -14.3f, 1)]
    [InlineData(50f, 80.95f, 2)]
    [InlineData(100f, 176.2f, 1)]
    [InlineData(500f, 938.0952380952381f, 14)]
    [InlineData(1000f, 1890.48f, 2)]
    public void Test_float_extension_generic_with_parameter_from_rømer_and_to_celsius_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
