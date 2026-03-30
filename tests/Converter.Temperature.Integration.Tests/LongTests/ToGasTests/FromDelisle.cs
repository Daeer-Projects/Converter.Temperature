using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromDelisle
{
    [Theory]
    [InlineData(-53L, 1L)]
    [InlineData(-150L, 6L)]
    [InlineData(-218L, 10L)]
    public void Test_long_extensions_from_delisle_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-53L, 1L)]
    [InlineData(-150L, 6L)]
    [InlineData(-218L, 10L)]
    public void Test_long_extensions_generic_from_delisle_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Delisle>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-51L, "Temp too low for gas mark!")]
    [InlineData(-255L, "Temp too high for gas mark!")]
    public void Test_long_extensions_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromDelisle()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(-51L, "Temp too low for gas mark!")]
    [InlineData(-255L, "Temp too high for gas mark!")]
    public void Test_long_extensions_generic_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Delisle>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
