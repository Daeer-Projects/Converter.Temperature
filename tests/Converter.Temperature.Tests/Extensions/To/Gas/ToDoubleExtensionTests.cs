namespace Converter.Temperature.Tests.Extensions.To.Gas;

using System;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Gas;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToDoubleExtensionTests
{
    [Theory]
    [InlineData(80, 0.25d)]
    [InlineData(114, 0.25d)]
    [InlineData(115, 0.5d)]
    [InlineData(134, 0.5d)]
    [InlineData(135, 1d)]
    [InlineData(144, 1d)]
    [InlineData(145, 2d)]
    [InlineData(154, 2d)]
    [InlineData(155, 3d)]
    [InlineData(174, 3d)]
    [InlineData(175, 4d)]
    [InlineData(184, 4d)]
    [InlineData(185, 5d)]
    [InlineData(194, 5d)]
    [InlineData(195, 6d)]
    [InlineData(209, 6d)]
    [InlineData(210, 7d)]
    [InlineData(224, 7d)]
    [InlineData(225, 8d)]
    [InlineData(234, 8d)]
    [InlineData(235, 9d)]
    [InlineData(244, 9d)]
    [InlineData(245, 10d)]
    [InlineData(269, 10d)]
    public void Test_to_gas_from_celsius_returns_correct_value(
        double input,
        double expected)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        double result = inputCelsius.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(80, 0.25d)]
    [InlineData(114, 0.25d)]
    [InlineData(115, 0.5d)]
    [InlineData(134, 0.5d)]
    [InlineData(135, 1d)]
    [InlineData(144, 1d)]
    [InlineData(145, 2d)]
    [InlineData(154, 2d)]
    [InlineData(155, 3d)]
    [InlineData(174, 3d)]
    [InlineData(175, 4d)]
    [InlineData(184, 4d)]
    [InlineData(185, 5d)]
    [InlineData(194, 5d)]
    [InlineData(195, 6d)]
    [InlineData(209, 6d)]
    [InlineData(210, 7d)]
    [InlineData(224, 7d)]
    [InlineData(225, 8d)]
    [InlineData(234, 8d)]
    [InlineData(235, 9d)]
    [InlineData(244, 9d)]
    [InlineData(245, 10d)]
    [InlineData(269, 10d)]
    public void Test_to_gas_from_celsius_generic_returns_correct_value(
        double input,
        double expected)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        double result = inputCelsius.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(79d, "Temp too low for gas mark!")]
    [InlineData(270d, "Temp too high for gas mark!")]
    public void Test_to_gas_from_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input,
        string expectedErrorMessage)
    {
        // Arrange.
        CelsiusDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedErrorMessage);
    }

    [Theory]
    [InlineData(79d, "Temp too low for gas mark!")]
    [InlineData(270d, "Temp too high for gas mark!")]
    public void Test_to_gas_from_celsius_generic_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input,
        string expectedErrorMessage)
    {
        // Arrange.
        CelsiusDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedErrorMessage);
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 6d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_gas_returns_same_value()
    {
        // Arrange.
        GasDouble input = new(7);

        // Act.
        double result = input.ToGas();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_generic_from_gas_returns_same_value()
    {
        // Arrange.
        GasDouble input = new(7);

        // Act.
        double result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_to_gas_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(double input)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData(0.24d)]
    [InlineData(10.1d)]
    public void Test_to_gas_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(
        double input)
    {
        // Arrange.
        GasDouble inputGas = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Fact]
    public void Test_to_gas_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 6d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 6d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 3d;
        RankineDouble input = new(806.67);

        // Act.
        double result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 3d;
        RankineDouble input = new(806.67);

        // Act.
        double result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}