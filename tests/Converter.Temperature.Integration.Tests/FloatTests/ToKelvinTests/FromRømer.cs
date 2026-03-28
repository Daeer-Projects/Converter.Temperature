using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToKelvinTests;

public class FromRømer
{
        [Theory]
    [InlineData(-1000f, -1645.8976190476192f)]
    [InlineData(0f, 258.8642857142857f)]
    [InlineData(50f, 354.10236f)]
    [InlineData(100f, 449.34045f)]
    [InlineData(500f, 1211.2452380952382f)]
    [InlineData(1000f, 2163.6261904761905f)]
    public void Test_float_extension_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f)]
    [InlineData(0f, 258.8642857142857f)]
    [InlineData(50f, 354.10236f)]
    [InlineData(100f, 449.34045f)]
    [InlineData(500f, 1211.2452380952382f)]
    [InlineData(1000f, 2163.6261904761905f)]
    public void Test_float_extension_generic_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f, -1)]
    [InlineData(0f, 258.8642857142857f, -1)]
    [InlineData(50f, 354.10236f, -1)]
    [InlineData(100f, 449.34045f, -1)]
    [InlineData(500f, 1211.2452380952382f, -1)]
    [InlineData(1000f, 2163.6261904761905f, -1)]
    [InlineData(-1000f, -1646f, 0)]
    [InlineData(0f, 259f, 0)]
    [InlineData(50f, 354f, 0)]
    [InlineData(100f, 449f, 0)]
    [InlineData(500f, 1211f, 0)]
    [InlineData(1000f, 2164f, 0)]
    [InlineData(-1000f, -1645.9f, 1)]
    [InlineData(0f, 258.8642857142857f, 13)]
    [InlineData(50f, 354.1024f, 4)]
    [InlineData(100f, 449.3f, 1)]
    [InlineData(500f, 1211.2452381f, 7)]
    [InlineData(1000f, 2163.6261904761905f, 14)]
    public void Test_float_extension_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRømer()
            .ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -1645.8976190476192f, -1)]
    [InlineData(0f, 258.8642857142857f, -1)]
    [InlineData(50f, 354.10236f, -1)]
    [InlineData(100f, 449.34045f, -1)]
    [InlineData(500f, 1211.2452380952382f, -1)]
    [InlineData(1000f, 2163.6261904761905f, -1)]
    [InlineData(-1000f, -1646f, 0)]
    [InlineData(0f, 259f, 0)]
    [InlineData(50f, 354f, 0)]
    [InlineData(100f, 449f, 0)]
    [InlineData(500f, 1211f, 0)]
    [InlineData(1000f, 2164f, 0)]
    [InlineData(-1000f, -1645.9f, 1)]
    [InlineData(0f, 258.8642857142857f, 13)]
    [InlineData(50f, 354.1024f, 4)]
    [InlineData(100f, 449.3f, 1)]
    [InlineData(500f, 1211.2452381f, 7)]
    [InlineData(1000f, 2163.6261904761905f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rømer_and_to_kelvin_returns_correct_double_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rømer>()
            .To<Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
