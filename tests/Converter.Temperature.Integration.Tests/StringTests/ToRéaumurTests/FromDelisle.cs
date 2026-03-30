using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromDelisle
{
    [Theory]
    [InlineData("300", "-80")]
    [InlineData("150", "0")]
    [InlineData("0", "80")]
    public void Test_string_extensions_from_delisle_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("300", "-80")]
    [InlineData("150", "0")]
    [InlineData("0", "80")]
    public void Test_string_extensions_generic_from_delisle_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
