using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromGas
{
    [Theory]
    [InlineData(0.25d)]
    [InlineData(3d)]
    [InlineData(5d)]
    [InlineData(8d)]
    [InlineData(10d)]
    public void Test_double_extension_from_and_to_gas_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromGas()
            .ToGas();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.25d)]
    [InlineData(3d)]
    [InlineData(5d)]
    [InlineData(8d)]
    [InlineData(10d)]
    public void Test_double_extension_generic_from_and_to_gas_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.From<Gas>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_double_extension_from_and_to_gas_throws_exception(
        double value)
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
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_double_extension_generic_from_and_to_gas_throws_exception(
        double value)
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
