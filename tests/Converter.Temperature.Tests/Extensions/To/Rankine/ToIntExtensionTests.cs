namespace Converter.Temperature.Tests.Extensions.To.Rankine;

using System;
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

public sealed class ToIntExtensionTests : BaseToExtensionTests<RankineInt, int>
{
    public ToIntExtensionTests() : base(9999, GetData()) { }

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
        RankineInt value,
        int fractionalCount)
    {
        return value.ToRankine();
    }

    protected override int ToUsingGeneric(
        RankineInt value,
        int fractionalCount)
    {
        return value.To<Rankine>();
    }

    protected override RankineInt Create(
        int value)
    {
        return new RankineInt(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        CelsiusInt input = new(200);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        CelsiusInt input = new(200);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusInt inputCelsius = new(int.MaxValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusInt inputCelsius = new(int.MaxValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rankine_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 716;
        FahrenheitInt input = new(256);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 716;
        FahrenheitInt input = new(256);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        GasInt input = new(6);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 882;
        GasInt input = new(6);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 11860;
        KelvinInt input = new(6589);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 11860;
        KelvinInt input = new(6589);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineInt input = new(862);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineInt input = new(862);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(2156, 493)]
    [InlineData(1392, 270)]
    [InlineData(1193, 212)]
    [InlineData(1011, 159)]
    [InlineData(466, 0)]
    [InlineData(3, -135)]
    [InlineData(-7, -138)]
    public void Test_to_rankine_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerInt input = new(originalTemp);

        // Act.
        int result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2156, 493)]
    [InlineData(1392, 270)]
    [InlineData(1193, 212)]
    [InlineData(1011, 159)]
    [InlineData(466, 0)]
    [InlineData(3, -135)]
    [InlineData(-7, -138)]
    public void Test_to_rankine_generic_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerInt input = new(originalTemp);

        // Act.
        int result = input.To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
