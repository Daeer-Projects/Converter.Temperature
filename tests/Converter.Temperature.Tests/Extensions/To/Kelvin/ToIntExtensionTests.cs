namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Kelvin;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class ToIntExtensionTests : BaseToExtensionTests<KelvinInt, int>
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
        KelvinInt value,
        int fractionalCount)
    {
        return value.ToKelvin();
    }

    protected override int ToUsingGeneric(
        KelvinInt value,
        int fractionalCount)
    {
        return value.To<Kelvin>();
    }

    protected override KelvinInt Create(
        int value)
    {
        return new KelvinInt(value);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        CelsiusInt input = new(200);

        // Act.
        int result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        CelsiusInt input = new(200);

        // Act.
        int result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusInt inputCelsius = new(int.MaxValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusInt inputCelsius = new(int.MaxValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void Test_to_kelvin_from_fahrenheit_with_invalid_parameter_throws_exception(
        int temp)
    {
        // Arrange.
        FahrenheitInt input = new(temp);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void Test_to_kelvin_generic_from_fahrenheit_with_invalid_parameter_throws_exception(
        int temp)
    {
        // Arrange.
        FahrenheitInt input = new(temp);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        GasInt input = new(6);

        // Act.
        int result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 490;
        GasInt input = new(6);

        // Act.
        int result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinInt input = new(473);

        // Act.
        int result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinInt input = new(473);

        // Act.
        int result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 478;
        RankineInt input = new(862);

        // Act.
        int result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 478;
        RankineInt input = new(862);

        // Act.
        int result = input.To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
