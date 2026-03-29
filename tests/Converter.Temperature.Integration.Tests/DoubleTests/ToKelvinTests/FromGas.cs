using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToKelvinTests;

public class FromGas
{
    [Fact]
    public void Test_double_extension_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_gas_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
