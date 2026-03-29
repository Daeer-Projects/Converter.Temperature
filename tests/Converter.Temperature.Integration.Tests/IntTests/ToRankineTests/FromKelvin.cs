using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    public void Test_int_extension_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    public void Test_int_extension_generic_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
