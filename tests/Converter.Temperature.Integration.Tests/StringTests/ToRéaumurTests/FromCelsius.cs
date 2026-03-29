using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromCelsius
{
    [Theory]
    [InlineData("0", "0")]
    [InlineData("100", "80")]
    public void Test_string_extension_from_celsius_to_réaumur_returns_correct_string_value(string input, string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromCelsius()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_celsius_to_réaumur_returns_correct_string_value()
    {
        // Arrange.
        const string input = "100";
        const string expected = "80";

        // Act.
        string result = input.FromCelsius()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
