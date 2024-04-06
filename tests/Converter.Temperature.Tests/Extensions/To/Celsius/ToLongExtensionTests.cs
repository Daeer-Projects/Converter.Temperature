namespace Converter.Temperature.Tests.Extensions.To.Celsius;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Celsius;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToLongExtensionTests : BaseToExtensionTests<CelsiusLong, long>
{
    public ToLongExtensionTests() : base(999L, GetData()) { }

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
        CelsiusLong value,
        int fractionalCount)
    {
        return value.ToCelsius();
    }

    protected override long ToUsingGeneric(
        CelsiusLong value,
        int fractionalCount)
    {
        return value.To<Celsius>();
    }

    protected override CelsiusLong Create(
        long value)
    {
        return new CelsiusLong(value);
    }

    [Fact]
    public void Test_to_celsius_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 10L;
        FahrenheitLong input = new(50L);

        // Act.
        long result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 10L;
        FahrenheitLong input = new(50L);

        // Act.
        long result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 230L;
        GasLong input = new(7L);

        // Act.
        long result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1L, 150L)]
    [InlineData(2L, 165L)]
    [InlineData(3L, 180L)]
    [InlineData(4L, 190L)]
    [InlineData(5L, 202L)]
    [InlineData(6L, 217L)]
    [InlineData(7L, 230L)]
    [InlineData(8L, 240L)]
    [InlineData(9L, 250L)]
    public void Test_to_celsius_generic_from_gas_returns_correct_value(
        long input,
        long expected)
    {
        // Arrange.
        GasLong inputGas = new(input);

        // Act.
        long result = inputGas.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 1L;
        KelvinLong input = new(274L);

        // Act.
        long result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 1L;
        KelvinLong input = new(274L);

        // Act.
        long result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = -121L;
        RankineLong input = new(274L);

        // Act.
        long result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_celsius_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = -121L;
        RankineLong input = new(274L);

        // Act.
        long result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925L, 493L)]
    [InlineData(500L, 270L)]
    [InlineData(390L, 212L)]
    [InlineData(290L, 160L)]
    [InlineData(-14L, 0L)]
    [InlineData(-273L, -136L)]
    public void Test_to_celsius_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(925L, 493L)]
    [InlineData(500L, 270L)]
    [InlineData(390L, 212L)]
    [InlineData(290L, 160L)]
    [InlineData(-14L, 0L)]
    [InlineData(-273L, -136L)]
    public void Test_to_celsius_generic_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
