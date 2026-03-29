using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromGas
{
    [Fact]
    public void Test_string_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        const string input = "6";

        // Act.
        string result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "473.15";
        const string input = "6";

        // Act.
        string result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
