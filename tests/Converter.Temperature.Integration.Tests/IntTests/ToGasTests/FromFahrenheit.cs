using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToGasTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_gas_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 6;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_fahrenheit_to_gas_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 6;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
