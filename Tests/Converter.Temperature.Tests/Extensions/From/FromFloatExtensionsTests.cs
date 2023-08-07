namespace Converter.Temperature.Tests.Extensions.From;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class FromFloatExtensionsTests
{
    [Fact]
    public void Test_from_celsius_returns_celsius_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        CelsiusFloat result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<TemperatureTypes.Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FahrenheitFloat result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<TemperatureTypes.Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_returns_gas_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        GasFloat result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        KelvinFloat result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        RankineFloat result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
