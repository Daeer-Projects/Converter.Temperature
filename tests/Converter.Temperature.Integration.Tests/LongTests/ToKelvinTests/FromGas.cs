using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromGas
{
    [Fact]
    public void Test_long_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        const long input = 6L;

        // Act.
        long result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        const long input = 6L;

        // Act.
        long result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
