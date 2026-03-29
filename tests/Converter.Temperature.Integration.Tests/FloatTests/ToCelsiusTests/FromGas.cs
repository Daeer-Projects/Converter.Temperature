using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromGas
{
    [Theory]
    [InlineData(0.25f, 125f)]
    [InlineData(0.9f, 125f)]
    [InlineData(1f, 140f)]
    [InlineData(1.4f, 140f)]
    [InlineData(1.5f, 150f)]
    [InlineData(2.4f, 150f)]
    [InlineData(2.5f, 165f)]
    [InlineData(3.4f, 165f)]
    [InlineData(3.5f, 180f)]
    [InlineData(4.4f, 180f)]
    [InlineData(4.5f, 190f)]
    [InlineData(5.4f, 190f)]
    [InlineData(5.5f, 200f)]
    [InlineData(6.4f, 200f)]
    [InlineData(6.5f, 220f)]
    [InlineData(7.4f, 220f)]
    [InlineData(7.5f, 230f)]
    [InlineData(8.4f, 230f)]
    [InlineData(8.5f, 240f)]
    [InlineData(9.4f, 240f)]
    [InlineData(9.5f, 260f)]
    [InlineData(9.9f, 260f)]
    public void Test_float_extensions_from_gas_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromGas()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0.25f, 125f)]
    [InlineData(0.9f, 125f)]
    [InlineData(1f, 140f)]
    [InlineData(1.4f, 140f)]
    [InlineData(1.5f, 150f)]
    [InlineData(2.4f, 150f)]
    [InlineData(2.5f, 165f)]
    [InlineData(3.4f, 165f)]
    [InlineData(3.5f, 180f)]
    [InlineData(4.4f, 180f)]
    [InlineData(4.5f, 190f)]
    [InlineData(5.4f, 190f)]
    [InlineData(5.5f, 200f)]
    [InlineData(6.4f, 200f)]
    [InlineData(6.5f, 220f)]
    [InlineData(7.4f, 220f)]
    [InlineData(7.5f, 230f)]
    [InlineData(8.4f, 230f)]
    [InlineData(8.5f, 240f)]
    [InlineData(9.4f, 240f)]
    [InlineData(9.5f, 260f)]
    [InlineData(9.9f, 260f)]
    public void Test_float_extensions_generic_from_gas_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Gas>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void
        Test_float_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
            float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void
        Test_float_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
            float input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
