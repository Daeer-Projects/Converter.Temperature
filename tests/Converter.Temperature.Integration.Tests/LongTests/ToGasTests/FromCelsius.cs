using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromCelsius
{
    [Fact]
    public void Test_long_extensions_from_celsius_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 6L;
        const long input = 200L;

        // Act.
        long result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_gas_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 6L;
        const long input = 200L;

        // Act.
        long result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(135L, 1L)]
    [InlineData(144L, 1L)]
    [InlineData(145L, 2L)]
    [InlineData(154L, 2L)]
    [InlineData(155L, 3L)]
    [InlineData(174L, 3L)]
    [InlineData(175L, 4L)]
    [InlineData(184L, 4L)]
    [InlineData(185L, 5L)]
    [InlineData(194L, 5L)]
    [InlineData(195L, 6L)]
    [InlineData(209L, 6L)]
    [InlineData(210L, 7L)]
    [InlineData(224L, 7L)]
    [InlineData(225L, 8L)]
    [InlineData(234L, 8L)]
    [InlineData(235L, 9L)]
    [InlineData(244L, 9L)]
    [InlineData(245L, 10L)]
    [InlineData(269L, 10L)]
    public void Test_long_extensions_from_celsius_to_gas_returns_correct_gas_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(135L, 1L)]
    [InlineData(144L, 1L)]
    [InlineData(145L, 2L)]
    [InlineData(154L, 2L)]
    [InlineData(155L, 3L)]
    [InlineData(174L, 3L)]
    [InlineData(175L, 4L)]
    [InlineData(184L, 4L)]
    [InlineData(185L, 5L)]
    [InlineData(194L, 5L)]
    [InlineData(195L, 6L)]
    [InlineData(209L, 6L)]
    [InlineData(210L, 7L)]
    [InlineData(224L, 7L)]
    [InlineData(225L, 8L)]
    [InlineData(234L, 8L)]
    [InlineData(235L, 9L)]
    [InlineData(244L, 9L)]
    [InlineData(245L, 10L)]
    [InlineData(269L, 10L)]
    public void Test_long_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const long input = 74536L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_long_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const long input = 74536L;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData(134L, "Temp too low for gas mark!")]
    [InlineData(270L, "Temp too high for gas mark!")]
    public void Test_long_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(134L, "Temp too low for gas mark!")]
    [InlineData(270L, "Temp too high for gas mark!")]
    public void Test_long_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        long input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
