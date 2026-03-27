using System;
using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Rankine;

public sealed class ToLongExtensionTests : BaseToExtensionTests<RankineLong, long>
{
    public ToLongExtensionTests() : base(99999999L, GetData()) { }

    private static List<long> GetData()
    {
        return [999L, 0L, -999L];
    }

    protected override long To(
        RankineLong value,
        int fractionalCount)
    {
        return value.ToRankine();
    }

    protected override long ToUsingGeneric(
        RankineLong value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Rankine>();
    }

    protected override RankineLong Create(
        long value)
    {
        return new RankineLong(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusLong inputCelsius = new(long.MaxValue);

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
        CelsiusLong inputCelsius = new(long.MaxValue);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<TemperatureTypes.Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rankine_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 716L;
        FahrenheitLong input = new(256L);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 716L;
        FahrenheitLong input = new(256L);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 882L;
        GasLong input = new(6L);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 882L;
        GasLong input = new(6L);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 11860L;
        KelvinLong input = new(6589L);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 11860L;
        KelvinLong input = new(6589L);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineLong input = new(862L);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineLong input = new(862L);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(2156L, 493L)]
    [InlineData(1392L, 270L)]
    [InlineData(1193L, 212L)]
    [InlineData(1011L, 159L)]
    [InlineData(466L, 0L)]
    [InlineData(3L, -135L)]
    [InlineData(-7L, -138L)]
    public void Test_to_rankine_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2156L, 493L)]
    [InlineData(1392L, 270L)]
    [InlineData(1193L, 212L)]
    [InlineData(1011L, 159L)]
    [InlineData(466L, 0L)]
    [InlineData(3L, -135L)]
    [InlineData(-7L, -138L)]
    public void Test_to_rankine_generic_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
