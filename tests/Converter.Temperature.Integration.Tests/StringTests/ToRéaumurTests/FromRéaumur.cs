using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("-80", "-80")]
    [InlineData("0", "0")]
    [InlineData("80", "80")]
    public void Test_string_extensions_from_réaumur_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRéaumur()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-80", "-80")]
    [InlineData("0", "0")]
    [InlineData("80", "80")]
    public void Test_string_extensions_generic_from_réaumur_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Réaumur>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
