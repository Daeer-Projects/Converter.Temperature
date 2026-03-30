using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("64", "0.25")]
    [InlineData("160", "6")]
    [InlineData("196", "10")]
    public void Test_string_extensions_from_réaumur_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRéaumur()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("64", "0.25")]
    [InlineData("160", "6")]
    [InlineData("196", "10")]
    public void Test_string_extensions_generic_from_réaumur_to_gas_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Réaumur>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("63.2", "Temp too low for gas mark!")]
    [InlineData("216", "Temp too high for gas mark!")]
    public void Test_string_extensions_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        string input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData("63.2", "Temp too low for gas mark!")]
    [InlineData("216", "Temp too high for gas mark!")]
    public void Test_string_extensions_generic_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        string input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
