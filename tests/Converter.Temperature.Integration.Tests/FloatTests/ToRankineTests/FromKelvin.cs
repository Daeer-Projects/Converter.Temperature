using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000f, -1800f)]
    [InlineData(0f, 0f)]
    [InlineData(50f, 90f)]
    [InlineData(1000f, 1800f)]
    public void Test_float_extension_from_kelvin_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -1800f)]
    [InlineData(0f, 0f)]
    [InlineData(50f, 90f)]
    [InlineData(1000f, 1800f)]
    public void Test_float_extension_generic_from_kelvin_to_rankine_returns_correct_double_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
