using System;
using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

public sealed class ToLongExtensionTests : BaseToExtensionTests<KelvinLong, long>
{
    public ToLongExtensionTests() : base(9999L, GetData()) { }

    private static List<long> GetData()
    {
        return new List<long> { 999L, 0L, -999L };
    }

    protected override long To(
        KelvinLong value,
        int fractionalCount)
    {
        return value.ToKelvin();
    }

    protected override long ToUsingGeneric(
        KelvinLong value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Kelvin>();
    }

    protected override KelvinLong Create(
        long value)
    {
        return new KelvinLong(value);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusLong inputCelsius = new(long.MaxValue);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_with_invalid_parameter_throws_exception()
    {
        // Arrange.
        CelsiusLong inputCelsius = new(long.MaxValue);

        // Act.
        ArgumentOutOfRangeException
            result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<TemperatureTypes.Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        GasLong input = new(6L);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 490L;
        GasLong input = new(6L);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinLong input = new(473L);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinLong input = new(473L);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 479L;
        RankineLong input = new(862L);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 479L;
        RankineLong input = new(862L);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198L, 493L)]
    [InlineData(773L, 270L)]
    [InlineData(663L, 212L)]
    [InlineData(562L, 159L)]
    [InlineData(259L, 0L)]
    [InlineData(2L, -135L)]
    public void Test_to_kelvin_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198L, 493L)]
    [InlineData(773L, 270L)]
    [InlineData(663L, 212L)]
    [InlineData(562L, 159L)]
    [InlineData(259L, 0L)]
    [InlineData(2L, -135L)]
    public void Test_to_kelvin_generic_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
