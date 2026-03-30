using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromRankine
{
    [Theory]
    [InlineData("311.66999999999996", "-80.00000000000003")]
    [InlineData("491.66999999999996", "-2.5263741715914672E-14")]
    [InlineData("671.67", "79.99999999999997")]
    public void Test_string_extensions_from_rankine_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRankine()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("311.66999999999996", "-80.00000000000003")]
    [InlineData("491.66999999999996", "-2.5263741715914672E-14")]
    [InlineData("671.67", "79.99999999999997")]
    public void Test_string_extensions_generic_from_rankine_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Rankine>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
