using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromKelvin
{
    [Fact]
    public void Test_string_extensions_from_kelvin_to_gas_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "6";
        const string input = "473.15";

        // Act.
        string result = input.FromKelvin()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_kelvin_to_gas_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "6";
        const string input = "473.15";

        // Act.
        string result = input.From<Kelvin>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
