using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromKelvin
{
    [Fact]
    public void Test_double_extensions_from_kelvin_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 473.15d;

        // Act.
        double result = input.FromKelvin()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_kelvin_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 473.15d;

        // Act.
        double result = input.From<Kelvin>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
