namespace Converter.Temperature.Tests.Extensions.To.Gas;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Gas;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToFloatExtensionTests : BaseToExtensionTests<GasFloat, float>
{
    public ToFloatExtensionTests() : base(5f, GetData()) { }

    private static List<float> GetData()
    {
        return new List<float>
        {
            0.25f,
            5f,
            10f
        };
    }

    protected override float To(
        GasFloat value,
        int fractionalCount)
    {
        return value.ToGas(fractionalCount);
    }

    protected override float ToUsingGeneric(
        GasFloat value,
        int fractionalCount)
    {
        return value.To<Gas>(fractionalCount);
    }

    protected override GasFloat Create(
        float value)
    {
        return new GasFloat(value);
    }

    [Fact]
    public void Test_to_gas_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 6f;
        CelsiusFloat input = new(200);

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
        CelsiusFloat inputCelsius = new(input);

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
        CelsiusFloat inputGas = new(input);

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
        FahrenheitFloat input = new(392);

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
        FahrenheitFloat input = new(392);

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
        GasFloat input = new(7);

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
        GasFloat input = new(7);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(0.24f)]
    [InlineData(10.1f)]
    public void Test_to_gas_generic_from_gas_with_invalid_parameters_throws_argument_out_of_range_exception(
        float input)
    {
        // Arrange.
        GasFloat inputGas = new(input);

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
        KelvinFloat input = new(473.15f);

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
        KelvinFloat input = new(473.15f);

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
        RankineFloat input = new(806.67f);

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
        RankineFloat input = new(806.67f);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10f, 148.367f)]
    [InlineData(6f, 110.384f)]
    [InlineData(0.25f, 50.99f)]
    public void Test_to_gas_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10f, 148.367f)]
    [InlineData(6f, 110.384f)]
    [InlineData(0.25f, 50.99f)]
    public void Test_to_gas_generic_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
