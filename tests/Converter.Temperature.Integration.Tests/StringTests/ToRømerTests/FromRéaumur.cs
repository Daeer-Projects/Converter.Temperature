using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("-80", "-45")]
    [InlineData("0", "7.5")]
    [InlineData("80", "60")]
    public void Test_string_extensions_from_réaumur_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRéaumur()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-80", "-45")]
    [InlineData("0", "7.5")]
    [InlineData("80", "60")]
    public void Test_string_extensions_generic_from_réaumur_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Réaumur>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
