namespace Converter.Temperature.Tests.Extensions.To.Rankine;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Rankine;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToFloatExtensionTests : BaseToExtensionTests<RankineFloat, float>
{
    public ToFloatExtensionTests() : base(999999.999999f, GetData()) { }

    private static List<float> GetData()
    {
        return new List<float>
        {
            999.999f,
            0f,
            -999.999f
        };
    }

    protected override float To(
        RankineFloat value,
        int fractionalCount)
    {
        return value.ToRankine(fractionalCount);
    }

    protected override float ToUsingGeneric(
        RankineFloat value,
        int fractionalCount)
    {
        return value.To<Rankine>(fractionalCount);
    }

    protected override RankineFloat Create(
        float value)
    {
        return new RankineFloat(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67004f;
        CelsiusFloat input = new(200);

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
        CelsiusFloat input = new(200);

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
        FahrenheitFloat input = new(392);

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
        FahrenheitFloat input = new(392);

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
        GasFloat input = new(6);

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
        GasFloat input = new(6);

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
        KelvinFloat input = new(473.15f);

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
        KelvinFloat input = new(473.15f);

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
        RankineFloat input = new(851.67f);

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
        RankineFloat input = new(851.67f);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(2157.8528571428574f, 493.47f)]
    [InlineData(1391.67f, 270f)]
    [InlineData(1193.67f, 212.25f)]
    [InlineData(1013.67004f, 159.75f)]
    [InlineData(465.9557142857143f, 0f)]
    [InlineData(0.000030517578f, -135.90375f)]
    [InlineData(-10.40448f, -138.9384f)]
    public void Test_to_rankine_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.8528571428574f, 493.47f)]
    [InlineData(1391.67f, 270f)]
    [InlineData(1193.67f, 212.25f)]
    [InlineData(1013.67004f, 159.75f)]
    [InlineData(465.9557142857143f, 0f)]
    [InlineData(0.000030517578f, -135.90375f)]
    [InlineData(-10.40448f, -138.9384f)]
    public void Test_to_rankine_generic_from_rømer_returns_correct_value(
        float expected,
        float originalTemp)
    {
        // Arrange.
        RømerFloat input = new(originalTemp);

        // Act.
        float result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.9f, 1)]
    [InlineData(2157.852857142857f, 12)]
    public void Test_to_rankine_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.9f, 1)]
    [InlineData(2157.852857142857f, 12)]
    public void Test_to_rankine_generic_with_parameter_from_rømer_returns_correct_value(
        float expected,
        int fractionalCount)
    {
        // Arrange.
        RømerFloat input = new(493.47f);

        // Act.
        float result = input.To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
