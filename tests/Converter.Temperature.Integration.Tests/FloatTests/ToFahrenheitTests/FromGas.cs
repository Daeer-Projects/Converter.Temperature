using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromGas
{
    [Fact]
    public void Test_float_extensions_from_gas_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 428f;
        const float input = 7f;

        // Act.
        float result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_gas_to_fahrenheit_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 428f;
        const float input = 7f;

        // Act.
        float result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
