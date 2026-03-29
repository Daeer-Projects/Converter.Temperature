using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromGas
{
    [Theory]
    [InlineData(1L, 302L)]
    [InlineData(2L, 329L)]
    [InlineData(3L, 356L)]
    [InlineData(4L, 374L)]
    [InlineData(5L, 396L)]
    [InlineData(6L, 423L)]
    [InlineData(7L, 446L)]
    [InlineData(8L, 464L)]
    [InlineData(9L, 482L)]
    [InlineData(10L, 509L)]
    public void Test_long_extensions_from_gas_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1L, 302L)]
    [InlineData(2L, 329L)]
    [InlineData(3L, 356L)]
    [InlineData(4L, 374L)]
    [InlineData(5L, 396L)]
    [InlineData(6L, 423L)]
    [InlineData(7L, 446L)]
    [InlineData(8L, 464L)]
    [InlineData(9L, 482L)]
    [InlineData(10L, 509L)]
    public void Test_long_extensions_generic_from_gas_to_fahrenheit_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void
        Test_long_extensions_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas()
            .ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0L)]
    [InlineData(11L)]
    public void
        Test_long_extensions_generic_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>()
            .To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
