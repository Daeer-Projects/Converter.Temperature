namespace Converter.Temperature.Integration.Tests.DoubleTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Gas;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToGasDoubleTests
{
    #region From Celsius

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
            .Be(expected);
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
            .Be(expected);
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
            .Be(expected);
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
            .Be(expected);
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

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_double_extensions_from_fahrenheit_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_double_extensions_from_kelvin_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 473.15d;

        // Act.
        double result = input.FromKelvin()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_kelvin_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 6d;
        const double input = 473.15d;

        // Act.
        double result = input.From<Kelvin>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

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

    #endregion From Gas

    #region From Rankine

    [Fact]
    public void Test_double_extensions_from_rankine_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 3d;
        const double input = 806.67d;

        // Act.
        double result = input.FromRankine()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_rankine_to_gas_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 3d;
        const double input = 806.67d;

        // Act.
        double result = input.From<Rankine>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 405.2368d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_generic_from_rankine_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 405.2368d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 1002.89786d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_generic_from_rankine_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 1002.89786d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rankine>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_double_extensions_from_rømer_to_gas_returns_correct_gas_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRømer()
            .ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_double_extensions_generic_from_rømer_to_gas_returns_correct_gas_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Rømer>()
            .To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 48.975d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_generic_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 48.975d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 149.25d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_double_extensions_generic_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const double input = 149.25d;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    #endregion From Rømer
}
