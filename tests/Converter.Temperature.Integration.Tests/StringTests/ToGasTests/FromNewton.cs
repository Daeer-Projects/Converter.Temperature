using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromNewton
{
    [Theory]
    [InlineData("26.4", "0.25")]
    [InlineData("66", "6")]
    [InlineData("80.85", "9")]
    public void Test_string_extensions_from_newton_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("26.4", "0.25")]
    [InlineData("66", "6")]
    [InlineData("80.85", "9")]
    public void Test_string_extensions_generic_from_newton_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("26.07", "Temp too low for gas mark!")]
    [InlineData("89.1", "Temp too high for gas mark!")]
    public void Test_string_extensions_from_newton_to_gas_with_invalid_parameters_throws_exception(
        string input,
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
    [InlineData("26.07", "Temp too low for gas mark!")]
    [InlineData("89.1", "Temp too high for gas mark!")]
    public void Test_string_extensions_generic_from_newton_to_gas_with_invalid_parameters_throws_exception(
        string input,
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

