using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromKelvin
{
    [Theory]
    [InlineData("173.14999999999998", "-80")]
    [InlineData("273.15", "0")]
    [InlineData("373.15", "80")]
    public void Test_string_extensions_from_kelvin_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromKelvin()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("173.14999999999998", "-80")]
    [InlineData("273.15", "0")]
    [InlineData("373.15", "80")]
    public void Test_string_extensions_generic_from_kelvin_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Kelvin>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
