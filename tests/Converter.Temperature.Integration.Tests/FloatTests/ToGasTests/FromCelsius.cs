using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromCelsius
{
    [Fact]
    public void Test_float_extensions_from_celsius_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_gas_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 6f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(80f, 0.25f)]
    [InlineData(114f, 0.25f)]
    [InlineData(115f, 0.5f)]
    [InlineData(134f, 0.5f)]
    [InlineData(135f, 1f)]
    [InlineData(144f, 1f)]
    [InlineData(145f, 2f)]
    [InlineData(154f, 2f)]
    [InlineData(155f, 3f)]
    [InlineData(174f, 3f)]
    [InlineData(175f, 4f)]
    [InlineData(184f, 4f)]
    [InlineData(185f, 5f)]
    [InlineData(194f, 5f)]
    [InlineData(195f, 6f)]
    [InlineData(209f, 6f)]
    [InlineData(210f, 7f)]
    [InlineData(224f, 7f)]
    [InlineData(225f, 8f)]
    [InlineData(234f, 8f)]
    [InlineData(235f, 9f)]
    [InlineData(244f, 9f)]
    [InlineData(245f, 10f)]
    [InlineData(269f, 10f)]
    public void Test_float_extensions_from_celsius_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(80f, 0.25f)]
    [InlineData(114f, 0.25f)]
    [InlineData(115f, 0.5f)]
    [InlineData(134f, 0.5f)]
    [InlineData(135f, 1f)]
    [InlineData(144f, 1f)]
    [InlineData(145f, 2f)]
    [InlineData(154f, 2f)]
    [InlineData(155f, 3f)]
    [InlineData(174f, 3f)]
    [InlineData(175f, 4f)]
    [InlineData(184f, 4f)]
    [InlineData(185f, 5f)]
    [InlineData(194f, 5f)]
    [InlineData(195f, 6f)]
    [InlineData(209f, 6f)]
    [InlineData(210f, 7f)]
    [InlineData(224f, 7f)]
    [InlineData(225f, 8f)]
    [InlineData(234f, 8f)]
    [InlineData(235f, 9f)]
    [InlineData(244f, 9f)]
    [InlineData(245f, 10f)]
    [InlineData(269f, 10f)]
    public void Test_float_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const float input = 74536.9876f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const float input = 74536.9876f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData(79f, "Temp too low for gas mark!")]
    [InlineData(270f, "Temp too high for gas mark!")]
    public void Test_float_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(79f, "Temp too low for gas mark!")]
    [InlineData(270f, "Temp too high for gas mark!")]
    public void Test_float_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
