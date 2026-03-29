using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Gas;

public sealed class ToIntExtensionTests : BaseToExtensionTests<GasInt, int>
{
    public ToIntExtensionTests() : base(5, GetData()) { }

    private static List<int> GetData()
    {
        return [1, 5, 10];
    }

    protected override int To(
        GasInt value,
        int fractionalCount)
    {
        return value.ToGas();
    }

    protected override int ToUsingGeneric(
        GasInt value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Gas>();
    }

    protected override GasInt Create(
        int value)
    {
        return new GasInt(value);
    }

    [Fact]
    public void Test_to_gas_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        CelsiusInt input = new(200);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(140, 1)]
    [InlineData(150, 2)]
    [InlineData(165, 3)]
    [InlineData(180, 4)]
    [InlineData(190, 5)]
    [InlineData(200, 6)]
    [InlineData(220, 7)]
    [InlineData(230, 8)]
    [InlineData(240, 9)]
    public void Test_to_gas_generic_from_celsius_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        CelsiusInt inputCelsius = new(input);

        // Act.
        int result = inputCelsius.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_gas_returns_same_value()
    {
        // Arrange.
        GasInt input = new(7);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_generic_from_gas_returns_same_value()
    {
        // Arrange.
        GasInt input = new(7);

        // Act.
        int result = input.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        KelvinInt input = new(473);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        KelvinInt input = new(473);

        // Act.
        int result = input.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        RankineInt input = new(862);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 6;
        RankineInt input = new(862);

        // Act.
        int result = input.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10, 148)]
    [InlineData(6, 110)]
    [InlineData(1, 80)]
    public void Test_to_gas_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerInt input = new(originalTemp);

        // Act.
        int result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10, 148)]
    [InlineData(6, 110)]
    [InlineData(1, 80)]
    public void Test_to_gas_generic_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerInt input = new(originalTemp);

        // Act.
        int result = input.To<TemperatureTypes.Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
