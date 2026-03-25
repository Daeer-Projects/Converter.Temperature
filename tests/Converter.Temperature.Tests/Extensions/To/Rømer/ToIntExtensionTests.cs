using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Rømer;

public sealed class ToIntExtensionTests : BaseToExtensionTests<RømerInt, int>
{
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
        RømerInt value,
        int fractionalCount)
    {
        return value.ToRømer();
    }

    protected override int ToUsingGeneric(
        RømerInt value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Rømer>();
    }

    protected override RømerInt Create(int value)
    {
        return new RømerInt(value);
    }

    [Fact]
    public void Test_to_rømer_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 113;
        CelsiusInt input = new(200);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 113;
        CelsiusInt input = new(200);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 113;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 113;
        FahrenheitInt input = new(392);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 121;
        GasInt input = new(6);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 121;
        GasInt input = new(6);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 112;
        KelvinInt input = new(473);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 112;
        KelvinInt input = new(473);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 112;
        RankineInt input = new(851);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 112;
        RankineInt input = new(851);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerInt input = new(851);

        // Act.
        int result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerInt input = new(851);

        // Act.
        int result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
