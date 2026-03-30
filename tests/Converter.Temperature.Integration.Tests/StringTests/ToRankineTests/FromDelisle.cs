using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromDelisle
{
    [Theory]
    [InlineData("300", "311.66999999999996")]
    [InlineData("150", "491.66999999999996")]
    [InlineData("0", "671.67")]
    public void Test_string_extensions_from_delisle_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("300", "311.66999999999996")]
    [InlineData("150", "491.66999999999996")]
    [InlineData("0", "671.67")]
    public void Test_string_extensions_generic_from_delisle_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
