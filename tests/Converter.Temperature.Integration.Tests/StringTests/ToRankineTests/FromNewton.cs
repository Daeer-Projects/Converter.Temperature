using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromNewton
{
    [Theory]
    [InlineData("-33", "311.67")]
    [InlineData("0", "491.67")]
    [InlineData("33", "671.6700000000001")]
    public void Test_string_extensions_from_newton_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-33", "311.67")]
    [InlineData("0", "491.67")]
    [InlineData("33", "671.6700000000001")]
    public void Test_string_extensions_generic_from_newton_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
