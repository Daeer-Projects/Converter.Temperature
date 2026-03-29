using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToGasTests;

public class FromCelsius
{
    [Fact]
    public void Test_int_extensions_from_celsius_to_gas_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 6;
        const int input = 200;

        // Act.
        int result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_celsius_to_gas_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 6;
        const int input = 200;

        // Act.
        int result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(135, 1)]
    [InlineData(144, 1)]
    [InlineData(145, 2)]
    [InlineData(154, 2)]
    [InlineData(155, 3)]
    [InlineData(174, 3)]
    [InlineData(175, 4)]
    [InlineData(184, 4)]
    [InlineData(185, 5)]
    [InlineData(194, 5)]
    [InlineData(195, 6)]
    [InlineData(209, 6)]
    [InlineData(210, 7)]
    [InlineData(224, 7)]
    [InlineData(225, 8)]
    [InlineData(234, 8)]
    [InlineData(235, 9)]
    [InlineData(244, 9)]
    [InlineData(245, 10)]
    [InlineData(269, 10)]
    public void Test_int_extensions_from_celsius_to_gas_returns_correct_gas_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(135, 1)]
    [InlineData(144, 1)]
    [InlineData(145, 2)]
    [InlineData(154, 2)]
    [InlineData(155, 3)]
    [InlineData(174, 3)]
    [InlineData(175, 4)]
    [InlineData(184, 4)]
    [InlineData(185, 5)]
    [InlineData(194, 5)]
    [InlineData(195, 6)]
    [InlineData(209, 6)]
    [InlineData(210, 7)]
    [InlineData(224, 7)]
    [InlineData(225, 8)]
    [InlineData(234, 8)]
    [InlineData(235, 9)]
    [InlineData(244, 9)]
    [InlineData(245, 10)]
    [InlineData(269, 10)]
    public void Test_int_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const int input = 74536;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_int_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const int input = 74536;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData(79, "Temp too low for gas mark!")]
    [InlineData(270, "Temp too high for gas mark!")]
    public void Test_int_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        int input,
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
    [InlineData(79, "Temp too low for gas mark!")]
    [InlineData(270, "Temp too high for gas mark!")]
    public void Test_int_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        int input,
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
