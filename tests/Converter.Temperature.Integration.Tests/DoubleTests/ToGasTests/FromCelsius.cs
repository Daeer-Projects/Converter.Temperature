using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToGasTests;

public class FromCelsius
{
        [Fact]
    public void Test_double_extensions_from_celsius_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(80d, 0.25d)]
    [InlineData(114d, 0.25d)]
    [InlineData(115d, 0.5d)]
    [InlineData(134d, 0.5d)]
    [InlineData(135d, 1d)]
    [InlineData(144d, 1d)]
    [InlineData(145d, 2d)]
    [InlineData(154d, 2d)]
    [InlineData(155d, 3d)]
    [InlineData(174d, 3d)]
    [InlineData(175d, 4d)]
    [InlineData(184d, 4d)]
    [InlineData(185d, 5d)]
    [InlineData(194d, 5d)]
    [InlineData(195d, 6d)]
    [InlineData(209d, 6d)]
    [InlineData(210d, 7d)]
    [InlineData(224d, 7d)]
    [InlineData(225d, 8d)]
    [InlineData(234d, 8d)]
    [InlineData(235d, 9d)]
    [InlineData(244d, 9d)]
    [InlineData(245d, 10d)]
    [InlineData(269d, 10d)]
    public void Test_double_extensions_from_celsius_to_gas_returns_correct_gas_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(80d, 0.25d)]
    [InlineData(114d, 0.25d)]
    [InlineData(115d, 0.5d)]
    [InlineData(134d, 0.5d)]
    [InlineData(135d, 1d)]
    [InlineData(144d, 1d)]
    [InlineData(145d, 2d)]
    [InlineData(154d, 2d)]
    [InlineData(155d, 3d)]
    [InlineData(174d, 3d)]
    [InlineData(175d, 4d)]
    [InlineData(184d, 4d)]
    [InlineData(185d, 5d)]
    [InlineData(194d, 5d)]
    [InlineData(195d, 6d)]
    [InlineData(209d, 6d)]
    [InlineData(210d, 7d)]
    [InlineData(224d, 7d)]
    [InlineData(225d, 8d)]
    [InlineData(234d, 8d)]
    [InlineData(235d, 9d)]
    [InlineData(244d, 9d)]
    [InlineData(245d, 10d)]
    [InlineData(269d, 10d)]
    public void Test_double_extensions_generic_from_celsius_to_gas_returns_correct_gas_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Celsius>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extensions_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const double input = 74536.9876d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_gas_with_large_value_throws_exception()
    {
        // Arrange.
        const double input = 74536.9876d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Theory]
    [InlineData(79d, "Temp too low for gas mark!")]
    [InlineData(270d, "Temp too high for gas mark!")]
    public void Test_double_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        double input,
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
    [InlineData(79d, "Temp too low for gas mark!")]
    [InlineData(270d, "Temp too high for gas mark!")]
    public void Test_double_extensions_generic_from_celsius_to_gas_with_invalid_parameters_throws_exception(
        double input,
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
