namespace Converter.Temperature.Tests.Extensions.To;

using System;
using FluentAssertions;
using Temperature.Extensions.To;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public class ToFloatExtensionsTests
{
    [Fact]
    public void Test_to_celsius_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusFloat input = new CelsiusFloat(42);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_generic_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusFloat input = new CelsiusFloat(42.3f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 10f;
        FahrenheitFloat input = new FahrenheitFloat(50);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 10f;
        FahrenheitFloat input = new FahrenheitFloat(50.0f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 220f;
        GasFloat input = new GasFloat(7.0f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
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
    public void Test_to_celsius_generic_from_gas_returns_correct_value(
        float input,
        float expected)
    {
        // Arrange.
        GasFloat inputGas = new GasFloat(input);

        // Act.
        float result = inputGas.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_to_celsius_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(float input)
    {
        // Arrange.
        GasFloat inputGas = new GasFloat(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 1f;
        KelvinFloat input = new KelvinFloat(274.15f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 1f;
        KelvinFloat input = new KelvinFloat(274.15f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2.7f, 1)]
    [InlineData(2.711304f, 6)]
    public void Test_to_celsius_with_parameter_from_kelvin_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinFloat input = new KelvinFloat(275.8612978f);

        // Act.
        float result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2.7f, 1)]
    [InlineData(2.711304f, 6)]
    public void Test_to_celsius_generic_with_parameter_from_kelvin_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        KelvinFloat input = new KelvinFloat(275.8612978f);

        // Act.
        float result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 0.9999932f;
        RankineFloat input = new RankineFloat(493.47f);

        // Act.
        float result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 0.9999932f;
        RankineFloat input = new RankineFloat(493.47f);

        // Act.
        float result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0f, 1)]
    [InlineData(0.999993f, 6)]
    public void Test_to_celsius_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new RankineFloat(493.47f);

        // Act.
        float result = input.ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1.0f, 1)]
    [InlineData(0.999993f, 6)]
    public void Test_to_celsius_generic_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new RankineFloat(493.47f);

        // Act.
        float result = input.To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 53.6f;
        CelsiusFloat input = new CelsiusFloat(12);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 53.6f;
        CelsiusFloat input = new CelsiusFloat(12);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitFloat input = new FahrenheitFloat(50.456f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitFloat input = new FahrenheitFloat(50.456f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(50.5f, 1)]
    [InlineData(50.46f, 2)]
    public void Test_to_fahrenheit_with_round_parameter_from_fahrenheit_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        FahrenheitFloat input = new FahrenheitFloat(50.456f);

        // Act.
        float result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50.5f, 1)]
    [InlineData(50.46f, 2)]
    public void Test_to_fahrenheit_generic_parameter_from_fahrenheit_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        FahrenheitFloat input = new FahrenheitFloat(50.456f);

        // Act.
        float result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 428f;
        GasFloat input = new GasFloat(7);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 428f;
        GasFloat input = new GasFloat(7);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.8f;
        KelvinFloat input = new KelvinFloat(274.15f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.8f;
        KelvinFloat input = new KelvinFloat(274.15f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_to_fahrenheit_from_kelvin_with_invalid_parameter_throws_exception(float input)
    {
        // Arrange.
        KelvinFloat inputKelvin = new KelvinFloat(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputKelvin.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.800995f;
        RankineFloat input = new RankineFloat(493.471f);

        // Act.
        float result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 33.800995f;
        RankineFloat input = new RankineFloat(493.471f);

        // Act.
        float result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8f, 1)]
    [InlineData(33.801f, 3)]
    public void Test_to_fahrenheit_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new RankineFloat(493.471f);

        // Act.
        float result = input.ToFahrenheit(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(33.8f, 1)]
    [InlineData(33.801f, 3)]
    public void Test_to_fahrenheit_generic_with_parameter_from_rankine_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RankineFloat input = new RankineFloat(493.471f);

        // Act.
        float result = input.To<Fahrenheit>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 6f;
        CelsiusFloat input = new CelsiusFloat(200);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(80, 0.25f)]
    [InlineData(114, 0.25f)]
    [InlineData(115, 0.5f)]
    [InlineData(134, 0.5f)]
    [InlineData(135, 1f)]
    [InlineData(144, 1f)]
    [InlineData(145, 2f)]
    [InlineData(154, 2f)]
    [InlineData(155, 3f)]
    [InlineData(174, 3f)]
    [InlineData(175, 4f)]
    [InlineData(184, 4f)]
    [InlineData(185, 5f)]
    [InlineData(194, 5f)]
    [InlineData(195, 6f)]
    [InlineData(209, 6f)]
    [InlineData(210, 7f)]
    [InlineData(224, 7f)]
    [InlineData(225, 8f)]
    [InlineData(234, 8f)]
    [InlineData(235, 9f)]
    [InlineData(244, 9f)]
    [InlineData(245, 10f)]
    [InlineData(269, 10f)]
    public void Test_to_gas_from_celsius_generic_returns_correct_value(
        float input,
        float expected)
    {
        // Arrange.
        CelsiusFloat inputCelsius = new CelsiusFloat(input);

        // Act.
        float result = inputCelsius.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(79f, "Temp too low for gas mark!")]
    [InlineData(270f, "Temp too high for gas mark!")]
    public void Test_to_gas_from_celsius_generic_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input,
        string expectedErrorMessage)
    {
        // Arrange.
        CelsiusFloat inputGas = new CelsiusFloat(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputGas.To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedErrorMessage);
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 6f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 6f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_gas_returns_same_value()
    {
        // Arrange.
        GasFloat input = new GasFloat(7);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_generic_from_gas_returns_same_value()
    {
        // Arrange.
        GasFloat input = new GasFloat(7);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_to_gas_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(float input)
    {
        // Arrange.
        GasFloat inputGas = new GasFloat(input);

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
        const float expected = 6f;
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 6f;
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 3f;
        RankineFloat input = new RankineFloat(806.67f);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 3f;
        RankineFloat input = new RankineFloat(806.67f);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        CelsiusFloat input = new CelsiusFloat(200);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        CelsiusFloat input = new CelsiusFloat(200);

        // Act.
        float result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        GasFloat input = new GasFloat(6);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        GasFloat input = new GasFloat(6);

        // Act.
        float result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15002f;
        RankineFloat input = new RankineFloat(851.67f);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15002f;
        RankineFloat input = new RankineFloat(851.67f);

        // Act.
        float result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        CelsiusFloat input = new CelsiusFloat(200);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        CelsiusFloat input = new CelsiusFloat(200);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        FahrenheitFloat input = new FahrenheitFloat(392);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        GasFloat input = new GasFloat(6);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        GasFloat input = new GasFloat(6);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_same_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        KelvinFloat input = new KelvinFloat(473.15f);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineFloat input = new RankineFloat(851.67f);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineFloat input = new RankineFloat(851.67f);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}