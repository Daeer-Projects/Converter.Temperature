using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("-80", "-148")]
    [InlineData("0", "32")]
    [InlineData("80", "212")]
    public void Test_string_extensions_from_réaumur_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRéaumur()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-80", "-148")]
    [InlineData("0", "32")]
    [InlineData("80", "212")]
    public void Test_string_extensions_generic_from_réaumur_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Réaumur>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
