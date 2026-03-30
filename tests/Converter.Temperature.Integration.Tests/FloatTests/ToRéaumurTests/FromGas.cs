using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRéaumurTests;

public class FromGas
{
    [Theory]
    [InlineData(0.25f, 100f)]
    [InlineData(6f, 160f)]
    [InlineData(10f, 208f)]
    public void Test_float_extensions_from_gas_to_réaumur_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromGas()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0.25f, 100f)]
    [InlineData(6f, 160f)]
    [InlineData(10f, 208f)]
    public void Test_float_extensions_generic_from_gas_to_réaumur_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Gas>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }


    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extensions_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
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
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_float_extensions_generic_from_gas_to_réaumur_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
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
