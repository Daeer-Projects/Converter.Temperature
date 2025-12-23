namespace Converter.Temperature.Tests.Extensions.To.Fahrenheit;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Fahrenheit;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToLongExtensionTests : BaseToExtensionTests<FahrenheitLong, long>
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
        FahrenheitLong value,
        int fractionalCount)
    {
        return value.ToFahrenheit();
    }

    protected override long ToUsingGeneric(
        FahrenheitLong value,
        int fractionalCount)
    {
        return value.To<Fahrenheit>();
    }

    protected override FahrenheitLong Create(
        long value)
    {
        return new FahrenheitLong(value);
    }

    [Fact]
    public void Test_to_fahrenheit_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 54L;
        CelsiusLong input = new(12L);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 54L;
        CelsiusLong input = new(12L);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        CelsiusLong inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    public void Test_to_fahrenheit_generic_from_celsius_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        CelsiusLong inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Fahrenheit>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitLong input = new(50L);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        FahrenheitLong input = new(50L);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_fahrenheit_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 446L;
        GasLong input = new(7L);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 446L;
        GasLong input = new(7L);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 34L;
        KelvinLong input = new(274L);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 34L;
        KelvinLong input = new(274L);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = -186L;
        RankineLong input = new(274L);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_fahrenheit_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = -186L;
        RankineLong input = new(274L);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1697L, 493L)]
    [InlineData(932L, 270L)]
    [InlineData(733L, 212L)]
    [InlineData(555L, 160L)]
    [InlineData(6L, 0L)]
    [InlineData(-460L, -136L)]
    public void Test_to_fahrenheit_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1697L, 493L)]
    [InlineData(932L, 270L)]
    [InlineData(733L, 212L)]
    [InlineData(555L, 160L)]
    [InlineData(6L, 0L)]
    [InlineData(-460L, -136L)]
    public void Test_to_fahrenheit_generic_from_rømer_returns_correct_value(
        int expected,
        int originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
