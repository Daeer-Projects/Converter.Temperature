using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000f, -3422.285714285714f)]
    [InlineData(0f, 6.285715f)]
    [InlineData(50f, 177.71428571428572f)]
    [InlineData(100f, 349.14285714285717f)]
    [InlineData(500f, 1720.5714285714287f)]
    [InlineData(1000f, 3434.8571428571427f)]
    public void Test_double_extension_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f)]
    [InlineData(0f, 6.285715f)]
    [InlineData(50f, 177.71428571428572f)]
    [InlineData(100f, 349.14285714285717f)]
    [InlineData(500f, 1720.5714285714287f)]
    [InlineData(1000f, 3434.8571428571427f)]
    public void Test_double_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f, -1)]
    [InlineData(0f, 6.285715f, -1)]
    [InlineData(50f, 177.71428571428572f, -1)]
    [InlineData(100f, 349.14285714285717f, -1)]
    [InlineData(500f, 1720.5714285714287f, -1)]
    [InlineData(1000f, 3434.8571428571427f, -1)]
    [InlineData(-1000f, -3422f, 0)]
    [InlineData(0f, 6f, 0)]
    [InlineData(50f, 178f, 0)]
    [InlineData(100f, 349f, 0)]
    [InlineData(500f, 1721f, 0)]
    [InlineData(1000f, 3435f, 0)]
    [InlineData(-1000f, -3422.3f, 1)]
    [InlineData(0f, 6.29f, 2)]
    [InlineData(50f, 177.7f, 1)]
    [InlineData(100f, 349.1f, 1)]
    [InlineData(500f, 1720.571428571429f, 14)]
    [InlineData(1000f, 3434.86f, 2)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -3422.285714285714f, -1)]
    [InlineData(0f, 6.285715f, -1)]
    [InlineData(50f, 177.71428571428572f, -1)]
    [InlineData(100f, 349.14285714285717f, -1)]
    [InlineData(500f, 1720.5714285714287f, -1)]
    [InlineData(1000f, 3434.8571428571427f, -1)]
    [InlineData(-1000f, -3422f, 0)]
    [InlineData(0f, 6f, 0)]
    [InlineData(50f, 178f, 0)]
    [InlineData(100f, 349f, 0)]
    [InlineData(500f, 1721f, 0)]
    [InlineData(1000f, 3435f, 0)]
    [InlineData(-1000f, -3422.3f, 1)]
    [InlineData(0f, 6.29f, 2)]
    [InlineData(50f, 177.7f, 1)]
    [InlineData(100f, 349.1f, 1)]
    [InlineData(500f, 1720.571428571429f, 14)]
    [InlineData(1000f, 3434.86f, 2)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_fahrenheit_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
