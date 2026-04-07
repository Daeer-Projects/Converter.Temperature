using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRéaumurTests;

public class FromGas
{
    [Theory]
    [InlineData(0.25d, 100d)]
    [InlineData(6d, 160d)]
    [InlineData(10d, 208d)]
    public void Test_double_extensions_from_gas_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromGas()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0.25d, 100d)]
    [InlineData(6d, 160d)]
    [InlineData(10d, 208d)]
    public void Test_double_extensions_generic_from_gas_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Gas>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_double_extensions_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input)
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
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_double_extensions_generic_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input)
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
