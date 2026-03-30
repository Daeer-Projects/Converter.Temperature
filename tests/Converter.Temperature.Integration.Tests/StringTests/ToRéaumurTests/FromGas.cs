using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromGas
{
    [Theory]
    [InlineData("0.25", "100")]
    [InlineData("6", "160")]
    [InlineData("10", "208")]
    public void Test_string_extensions_from_gas_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromGas()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("0.25", "100")]
    [InlineData("6", "160")]
    [InlineData("10", "208")]
    public void Test_string_extensions_generic_from_gas_to_réaumur_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Gas>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
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
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_generic_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
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
