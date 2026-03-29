using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_string_extension_from_kelvin_to_rankine_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_string_extension_generic_from_kelvin_to_rankine_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
