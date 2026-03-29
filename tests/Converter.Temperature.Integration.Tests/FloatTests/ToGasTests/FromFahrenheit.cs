using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 392f;

        // Act.
        float result = input.FromFahrenheit()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 392f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
