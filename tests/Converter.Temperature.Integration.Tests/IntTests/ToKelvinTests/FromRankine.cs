using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000, -556)]
    [InlineData(0, 0)]
    [InlineData(50, 28)]
    [InlineData(100, 56)]
    [InlineData(500, 278)]
    [InlineData(1000, 556)]
    public void Test_int_extension_from_rankine_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -556)]
    [InlineData(0, 0)]
    [InlineData(50, 28)]
    [InlineData(100, 56)]
    [InlineData(500, 278)]
    [InlineData(1000, 556)]
    public void Test_int_extension_generic_from_rankine_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
