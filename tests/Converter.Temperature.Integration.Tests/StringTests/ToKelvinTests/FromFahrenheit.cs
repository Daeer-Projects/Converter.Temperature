using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_string_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15000000000003";
        const string input = "392";

        // Act.
        string result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15000000000003";
        const string input = "392";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
