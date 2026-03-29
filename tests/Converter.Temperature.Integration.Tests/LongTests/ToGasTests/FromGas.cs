using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToGasTests;

public class FromGas
{
    [Theory]
    [InlineData(1L)]
    [InlineData(3L)]
    [InlineData(5L)]
    [InlineData(8L)]
    [InlineData(10L)]
    public void Test_long_extension_from_and_to_gas_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromGas()
            .ToGas();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(1L)]
    [InlineData(3L)]
    [InlineData(5L)]
    [InlineData(8L)]
    [InlineData(10L)]
    public void Test_long_extension_generic_from_and_to_gas_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Gas>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extension_from_and_to_gas_throws_exception(
        long value)
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
    [InlineData(0L)]
    [InlineData(11L)]
    public void Test_long_extension_generic_from_and_to_gas_throws_exception(
        long value)
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
