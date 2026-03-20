namespace Converter.Temperature.Tests.Extensions.To.Delisle;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Delisle;
using TemperatureTypes;
using Types.Celsius;
using Types.Delisle;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToLongExtensionTests : BaseToExtensionTests<DelisleLong, long>
{
    public ToLongExtensionTests() : base(9999L, GetData()) { }

    private static List<long> GetData()
    {
        return new List<long>
        {
            999L,
            0L,
            -999L
        };
    }

    protected override long To(
        DelisleLong value,
        int fractionalCount)
    {
        return value.ToDelisle();
    }

    protected override long ToUsingGeneric(
        DelisleLong value,
        int fractionalCount)
    {
        return value.To<Delisle>();
    }

    protected override DelisleLong Create(
        long value)
    {
        return new DelisleLong(value);
    }

    [Fact]
    public void Test_to_delisle_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        CelsiusLong input = new(0L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        CelsiusLong input = new(0L);

        // Act.
        long result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        FahrenheitLong input = new(32L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        FahrenheitLong input = new(32L);

        // Act.
        long result = input.To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = -176L;
        GasLong input = new(6L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        KelvinLong input = new(273L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        RankineLong input = new(492L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rømer_returns_correct_value()
    {
        // Arrange.
        const long expected = 150L;
        RømerLong input = new(8L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Fact]
    public void Test_to_delisle_from_delisle_returns_same_value()
    {
        // Arrange.
        DelisleLong input = new(150L);

        // Act.
        long result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
