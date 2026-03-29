using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToGasTests;

public class FromGas
{
    [Theory]
    [InlineData("0.25")]
    [InlineData("3")]
    [InlineData("5")]
    [InlineData("8")]
    [InlineData("10")]
    public void Test_string_extension_from_and_to_gas_returns_correct_string_value(
        string value)
    {
        // Arrange.
        // Act.
        string result = value.FromGas()
            .ToGas();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData("0.25")]
    [InlineData("3")]
    [InlineData("5")]
    [InlineData("8")]
    [InlineData("10")]
    public void Test_string_extension_generic_from_and_to_gas_returns_correct_string_value(
        string value)
    {
        // Arrange.
        // Act.
        string result = value.From<Gas>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extension_from_and_to_gas_throws_exception(
        string value)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => value.FromGas()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extension_generic_from_and_to_gas_throws_exception(
        string value)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => value.From<Gas>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
