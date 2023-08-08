namespace Converter.Temperature.Tests.Extensions.To.Gas;

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

public sealed class ToIntExtensionTests
{
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
}
