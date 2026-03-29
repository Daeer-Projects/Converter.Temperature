using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToFahrenheitTests;

public class FromGas
{
    [Fact]
    public void Test_double_extensions_from_gas_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 428d;
        const double input = 7d;

        // Act.
        double result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_gas_to_fahrenheit_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 428d;
        const double input = 7d;

        // Act.
        double result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
