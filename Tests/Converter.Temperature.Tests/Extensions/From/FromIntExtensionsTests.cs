using Converter.Temperature.Types.Rømer;

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

public sealed class FromIntExtensionsTests
{
    [Fact]
    public void Test_from_celsius_returns_celsius_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        CelsiusInt result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        FahrenheitInt result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_returns_gas_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        GasInt result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        KelvinInt result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        RankineInt result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        RømerInt result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
