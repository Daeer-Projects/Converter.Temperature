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
using Types.Rømer;
using Xunit;

public sealed class FromStringExtensionsTests
{
    [Fact]
    public void Test_from_celsius_returns_celsius_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        CelsiusString result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        FahrenheitString result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_returns_gas_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        GasString result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        KelvinString result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        RankineString result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        RømerString result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
