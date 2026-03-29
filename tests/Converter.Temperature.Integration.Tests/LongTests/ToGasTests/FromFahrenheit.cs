using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_long_extensions_from_fahrenheit_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 6L;
        const long input = 392L;

        // Act.
        long result = input.FromFahrenheit()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_fahrenheit_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 6L;
        const long input = 392L;

        // Act.
        long result = input.From<Fahrenheit>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
