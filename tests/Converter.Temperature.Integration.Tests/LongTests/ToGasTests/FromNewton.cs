using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromNewton
{
    [Theory]
    [InlineData(45L, 1L)]
    [InlineData(66L, 6L)]
    [InlineData(81L, 10L)]
    public void Test_long_extensions_from_newton_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(45L, 1L)]
    [InlineData(66L, 6L)]
    [InlineData(81L, 10L)]
    public void Test_long_extensions_generic_from_newton_to_gas_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(44L, "Temp too low for gas mark!")]
    [InlineData(89L, "Temp too high for gas mark!")]
    public void Test_long_extensions_from_newton_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(44L, "Temp too low for gas mark!")]
    [InlineData(89L, "Temp too high for gas mark!")]
    public void Test_long_extensions_generic_from_newton_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
