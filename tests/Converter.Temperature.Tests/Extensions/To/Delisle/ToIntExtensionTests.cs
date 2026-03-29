using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Delisle;

public sealed class ToIntExtensionTests : BaseToExtensionTests<DelisleInt, int>
{
    public ToIntExtensionTests() : base(9999, GetData()) { }

    private static List<int> GetData()
    {
        return [999, 0, -999];
    }

    protected override int To(
        DelisleInt value,
        int fractionalCount)
    {
        return value.ToDelisle();
    }

    protected override int ToUsingGeneric(
        DelisleInt value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Delisle>();
    }

    protected override DelisleInt Create(
        int value)
    {
        return new DelisleInt(value);
    }

    [Fact]
    public void Test_to_delisle_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        CelsiusInt input = new(0);

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        CelsiusInt input = new(0);

        // Act.
        int result = input.To<TemperatureTypes.Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        FahrenheitInt input = new(32);

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        FahrenheitInt input = new(32);

        // Act.
        int result = input.To<TemperatureTypes.Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = -176;
        GasInt input = new(6);

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = -176;
        GasInt input = new(6);

        // Act.
        int result = input.To<TemperatureTypes.Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        KelvinInt input = new(273); // 273K is approx 0C. (100 - 0) * 1.5 = 150.
        // Actually KelvinToDelisle uses (373.15 - input) * 1.5.
        // (373.15 - 273.15) * 1.5 = 150.
        // Since it's int, let's use 273. (373.15 - 273) * 1.5 = 100.15 * 1.5 = 150.225 -> 150.

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        RankineInt input = new(492); // 491.67R is 0C. (671.67 - 491.67) * 5/6 = 180 * 5/6 = 150.

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rømer_returns_correct_value()
    {
        // Arrange.
        const int expected = 150;
        RømerInt input = new(8);

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Fact]
    public void Test_to_delisle_from_delisle_returns_same_value()
    {
        // Arrange.
        DelisleInt input = new(150);

        // Act.
        int result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
