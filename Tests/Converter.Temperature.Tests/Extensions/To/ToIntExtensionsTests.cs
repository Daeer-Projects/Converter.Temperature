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

public sealed class ToIntExtensionsTests
{
    [Fact]
    public void Test_to_celsius_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusInt input = new(42);

        // Act.
        int result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_celsius_generic_from_celsius_returns_same_value()
    {
        // Arrange.
        CelsiusInt input = new(42);

        // Act.
        int result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
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

    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 54;
        CelsiusInt input = new(12);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 54;
        CelsiusInt input = new(12);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(int input)
    {
        // Arrange.
        CelsiusInt inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(int input)
    {
        // Arrange.
        CelsiusInt inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitInt input = new(50);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitInt input = new(50);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 446;
        GasInt input = new(7);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 446;
        GasInt input = new(7);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 34;
        KelvinInt input = new(274);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 34;
        KelvinInt input = new(274);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -186;
        RankineInt input = new(274);

        // Act.
        int result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = -186;
        RankineInt input = new(274);

        // Act.
        int result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
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
        int result = inputCelsius.To<Gas>();

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
        int result = input.To<Gas>();

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
        int result = input.To<Gas>();

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
        int result = input.To<Gas>();

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
        int result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
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
    public void Test_to_kelvin_from_fahrenheit_with_invalid_parameter_throws_exception(int temp)
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
    public void Test_to_kelvin_generic_from_fahrenheit_with_invalid_parameter_throws_exception(int temp)
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
}