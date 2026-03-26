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

public sealed class ToLongExtensionTests : BaseToExtensionTests<RømerLong, long>
{
    public ToLongExtensionTests() : base(999, GetData()) { }

    private static List<long> GetData()
    {
        return new List<long> { 999, 0, -999 };
    }

    protected override long To(
        RømerLong value,
        int fractionalCount)
    {
        return value.ToRømer();
    }

    protected override long ToUsingGeneric(
        RømerLong value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Rømer>();
    }

    protected override RømerLong Create(long value)
    {
        return new RømerLong(value);
    }

    [Fact]
    public void Test_to_rømer_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 113L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 113L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 113L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 113L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 121L;
        GasLong input = new(6L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 121L;
        GasLong input = new(6L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 112L;
        KelvinLong input = new(473L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 112L;
        KelvinLong input = new(473L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 112L;
        RankineLong input = new(851L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 112L;
        RankineLong input = new(851L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerLong input = new(851L);

        // Act.
        long result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerLong input = new(851L);

        // Act.
        long result = input.To<TemperatureTypes.Rømer>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
