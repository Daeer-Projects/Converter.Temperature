using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

public sealed class ToFloatExtensionTests : BaseToExtensionTests<KelvinFloat, float>
{
    public ToFloatExtensionTests() : base(999.999f, GetData()) { }

    private static List<float> GetData()
    {
        return [999.999f, 0f, -999.999f];
    }

    protected override float To(
        KelvinFloat value,
        int fractionalCount)
    {
        return value.ToKelvin(fractionalCount);
    }

    protected override float ToUsingGeneric(
        KelvinFloat value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Kelvin>(fractionalCount);
    }

    protected override KelvinFloat Create(
        float value)
    {
        return new KelvinFloat(value);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        CelsiusFloat input = new(200);

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
        CelsiusFloat input = new(200);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15002f;
        FahrenheitFloat input = new(392);

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
        const float expected = 473.15002f;
        FahrenheitFloat input = new(392);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15f;
        GasFloat input = new(6);

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
        GasFloat input = new(6);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinFloat input = new(473.15f);

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
        KelvinFloat input = new(473.15f);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 473.15002f;
        RankineFloat input = new(851.67f);

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
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.807142857143f, 493.47f)]
    [InlineData(773.15f, 270f)]
    [InlineData(663.15f, 212.25f)]
    [InlineData(563.15f, 159.75f)]
    [InlineData(258.8642857142857f, 0f)]
    [InlineData(0f, -135.90375f)]
    public void Test_to_kelvin_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.807142857143f, 493.47f)]
    [InlineData(773.15f, 270f)]
    [InlineData(663.15f, 212.25f)]
    [InlineData(563.15f, 159.75f)]
    [InlineData(258.8642857142857f, 0f)]
    [InlineData(0f, -135.90375f)]
    public void Test_to_kelvin_generic_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.8f, 1)]
    [InlineData(1198.80714285714f, 11)]
    public void Test_to_kelvin_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.8f, 1)]
    [InlineData(1198.80714285714f, 11)]
    public void Test_to_kelvin_generic_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.To<TemperatureTypes.Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
