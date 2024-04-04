namespace Converter.Temperature.Tests.Extensions.To.Gas;

using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Gas;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToLongExtensionTests : BaseToExtensionTests<GasLong, long>
{
    public ToLongExtensionTests() : base(5L, GetData()) { }

    private static List<long> GetData()
    {
        return new List<long>
        {
            1L,
            5L,
            10L
        };
    }

    protected override long To(
        GasLong value,
        int fractionalCount)
    {
        return value.ToGas();
    }

    protected override long ToUsingGeneric(
        GasLong value,
        int fractionalCount)
    {
        return value.To<Gas>();
    }

    protected override GasLong Create(
        long value)
    {
        return new GasLong(value);
    }

    [Fact]
    public void Test_to_gas_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        CelsiusLong input = new(200L);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(140L, 1L)]
    [InlineData(150L, 2L)]
    [InlineData(165L, 3L)]
    [InlineData(180L, 4L)]
    [InlineData(190L, 5L)]
    [InlineData(200L, 6L)]
    [InlineData(220L, 7L)]
    [InlineData(230L, 8L)]
    [InlineData(240L, 9L)]
    public void Test_to_gas_generic_from_celsius_returns_correct_value(
        long input,
        long expected)
    {
        // Arrange.
        CelsiusLong inputCelsius = new(input);

        // Act.
        long result = inputCelsius.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        FahrenheitLong input = new(392L);

        // Act.
        long result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_gas_returns_same_value()
    {
        // Arrange.
        GasLong input = new(7L);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_generic_from_gas_returns_same_value()
    {
        // Arrange.
        GasLong input = new(7L);

        // Act.
        long result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_gas_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        KelvinLong input = new(473L);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        KelvinLong input = new(473L);

        // Act.
        long result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        RankineLong input = new(862L);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_gas_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 6L;
        RankineLong input = new(862L);

        // Act.
        long result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10L, 148L)]
    [InlineData(6L, 110L)]
    [InlineData(1L, 80L)]
    public void Test_to_gas_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.ToGas();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(10L, 148L)]
    [InlineData(6L, 110L)]
    [InlineData(1L, 80L)]
    public void Test_to_gas_generic_from_rømer_returns_correct_value(
        long expected,
        long originalTemp)
    {
        // Arrange.
        RømerLong input = new(originalTemp);

        // Act.
        long result = input.To<Gas>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
