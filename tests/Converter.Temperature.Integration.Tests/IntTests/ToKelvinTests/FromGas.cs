using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromGas
{
    [Fact]
    public void Test_int_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        const int input = 6;

        // Act.
        int result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        const int input = 6;

        // Act.
        int result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
