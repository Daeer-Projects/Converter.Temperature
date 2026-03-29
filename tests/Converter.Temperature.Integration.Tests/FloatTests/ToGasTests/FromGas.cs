using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromGas
{
    [Theory]
    [InlineData(0.25f)]
    [InlineData(3f)]
    [InlineData(5f)]
    [InlineData(8f)]
    [InlineData(10f)]
    public void Test_float_extension_from_and_to_gas_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromGas()
            .ToGas();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.25f)]
    [InlineData(3f)]
    [InlineData(5f)]
    [InlineData(8f)]
    [InlineData(10f)]
    public void Test_float_extension_generic_from_and_to_gas_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.From<Gas>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extension_from_and_to_gas_throws_exception(
        float value)
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
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extension_generic_from_and_to_gas_throws_exception(
        float value)
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
