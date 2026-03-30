using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromGas
{
    [Theory]
    [InlineData("0.25", "41.25")]
    [InlineData("6", "66")]
    [InlineData("10", "85.8")]
    public void Test_string_extensions_from_gas_to_newton_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromGas()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("0.25", "41.25")]
    [InlineData("6", "66")]
    [InlineData("10", "85.8")]
    public void Test_string_extensions_generic_from_gas_to_newton_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Gas>()
            .To<Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_from_gas_to_newton_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
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
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_generic_from_gas_to_newton_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
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
