using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromGas
{
    [Theory]
    [InlineData(1, 302)]
    [InlineData(2, 329)]
    [InlineData(3, 356)]
    [InlineData(4, 374)]
    [InlineData(5, 396)]
    [InlineData(6, 423)]
    [InlineData(7, 446)]
    [InlineData(8, 464)]
    [InlineData(9, 482)]
    [InlineData(10, 509)]
    public void Test_int_extensions_from_gas_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1, 302)]
    [InlineData(2, 329)]
    [InlineData(3, 356)]
    [InlineData(4, 374)]
    [InlineData(5, 396)]
    [InlineData(6, 423)]
    [InlineData(7, 446)]
    [InlineData(8, 464)]
    [InlineData(9, 482)]
    [InlineData(10, 509)]
    public void Test_int_extensions_generic_from_gas_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Gas>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(11)]
    public void
        Test_int_extensions_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
            int input)
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
    [InlineData(0)]
    [InlineData(11)]
    public void
        Test_int_extensions_generic_from_gas_to_fahrenheit_with_invalid_parameters_throws_argument_out_of_range_exception(
            int input)
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
