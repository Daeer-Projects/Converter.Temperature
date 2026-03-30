using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromDelisle
{
    [Theory]
    [InlineData("30", "0.25")]
    [InlineData("-150", "6")]
    [InlineData("-217.5", "10")]
    public void Test_string_extensions_from_delisle_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("30", "0.25")]
    [InlineData("-150", "6")]
    [InlineData("-217.5", "10")]
    public void Test_string_extensions_generic_from_delisle_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("31.5", "Temp too low for gas mark!")]
    [InlineData("-255", "Temp too high for gas mark!")]
    public void Test_string_extensions_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        string input,
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
    [InlineData("31.5", "Temp too low for gas mark!")]
    [InlineData("-255", "Temp too high for gas mark!")]
    public void Test_string_extensions_generic_from_delisle_to_gas_with_invalid_parameters_throws_exception(
        string input,
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
