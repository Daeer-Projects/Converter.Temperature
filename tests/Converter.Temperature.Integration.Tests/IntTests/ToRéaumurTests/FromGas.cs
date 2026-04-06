using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromGas
{
    [Theory]
    [InlineData(1, 120)]
    [InlineData(6, 174)]
    [InlineData(10, 212)]
    public void Test_int_extensions_from_gas_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1, 120)]
    [InlineData(6, 174)]
    [InlineData(10, 212)]
    public void Test_int_extensions_generic_from_gas_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Gas>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas()
            .ToRéaumur());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(11)]
    public void Test_int_extensions_generic_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>()
            .To<Réaumur>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
