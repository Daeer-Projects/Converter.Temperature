using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_double_extension_from_kelvin_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_double_extension_generic_from_kelvin_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
