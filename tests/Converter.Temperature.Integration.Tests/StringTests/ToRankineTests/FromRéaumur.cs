using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("-80", "311.67")]
    [InlineData("0", "491.67")]
    [InlineData("80", "671.6700000000001")]
    public void Test_string_extensions_from_réaumur_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-80", "311.67")]
    [InlineData("0", "491.67")]
    [InlineData("80", "671.6700000000001")]
    public void Test_string_extensions_generic_from_réaumur_to_rankine_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
