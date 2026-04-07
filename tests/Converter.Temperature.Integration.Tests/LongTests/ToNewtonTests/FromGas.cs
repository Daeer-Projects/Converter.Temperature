using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromGas
{
    [Theory]
    [InlineData(1L, 50L)]
    [InlineData(6L, 72L)]
    [InlineData(10L, 87L)]
    public void Test_long_extensions_from_gas_to_newton_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1L, 50L)]
    [InlineData(6L, 72L)]
    [InlineData(10L, 87L)]
    public void Test_long_extensions_generic_from_gas_to_newton_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Gas>()
            .To<Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extensions_from_gas_to_newton_with_invalid_parameters_throws_argument_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas()
            .ToNewton());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extensions_generic_from_gas_to_newton_with_invalid_parameters_throws_argument_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>()
            .To<Newton>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
