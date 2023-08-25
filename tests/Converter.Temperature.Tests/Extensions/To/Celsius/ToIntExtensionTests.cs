namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToIntExtensionTests : BaseToExtensionTests<CelsiusInt, int>
{
    private const string RoundingExceptionMessage = "Rounding digits must be between 0 and 15, inclusive.";
    public ToIntExtensionTests() : base(999, GetData()) { }

    private static List<int> GetData()
    {
        return new List<int>
        {
            999,
            0,
            -999
        };
    }

    protected override int To(
        CelsiusInt value,
        int fractionalCount)
    {
        if (fractionalCount == 16)
#pragma warning disable CA2208
        {
            throw new ArgumentOutOfRangeException(RoundingExceptionMessage);
        }
#pragma warning restore CA2208
        return value.ToCelsius();
    }

    protected override int ToUsingGeneric(
        CelsiusInt value,
        int fractionalCount)
    {
        return value.To<Celsius>();
    }

    protected override CelsiusInt Create(
        int value)
    {
        return new CelsiusInt(value);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 10;
        FahrenheitInt input = new(50);

        // Act.
        int result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 10;
        FahrenheitInt input = new(50);

        // Act.
        int result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 230;
        GasInt input = new(7);

        // Act.
        int result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1, 150)]
    [InlineData(2, 165)]
    [InlineData(3, 180)]
    [InlineData(4, 190)]
    [InlineData(5, 202)]
    [InlineData(6, 217)]
    [InlineData(7, 230)]
    [InlineData(8, 240)]
    [InlineData(9, 250)]
    public void Test_to_celsius_generic_from_gas_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.
        GasInt inputGas = new(input);

        // Act.
        int result = inputGas.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 1;
        KelvinInt input = new(274);

        // Act.
        int result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 1;
        KelvinInt input = new(274);

        // Act.
        int result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -121;
        RankineInt input = new(274);

        // Act.
        int result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -121;
        RankineInt input = new(274);

        // Act.
        int result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
