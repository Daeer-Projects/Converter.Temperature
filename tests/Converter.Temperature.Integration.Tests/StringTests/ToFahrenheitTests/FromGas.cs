using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToFahrenheitTests;

public class FromGas
{
    [Fact]
    public void Test_string_extensions_from_gas_to_fahrenheit_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "428";
        const string input = "7";

        // Act.
        string result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_gas_to_fahrenheit_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "428";
        const string input = "7";

        // Act.
        string result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
