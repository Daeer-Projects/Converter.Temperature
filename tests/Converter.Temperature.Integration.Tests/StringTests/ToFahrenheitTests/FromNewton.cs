using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromNewton
{
    [Theory]
    [InlineData("-33", "-148")]
    [InlineData("0", "32")]
    [InlineData("33", "212")]
    public void Test_string_extensions_from_newton_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-33", "-148")]
    [InlineData("0", "32")]
    [InlineData("33", "212")]
    public void Test_string_extensions_generic_from_newton_to_fahrenheit_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
