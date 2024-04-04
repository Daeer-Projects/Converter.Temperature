namespace Converter.Temperature.Tests.Extensions.To.Rømer;

using System;
using System.Collections.Generic;
using FluentAssertions;
using Temperature.Extensions.To;
using Temperature.Extensions.To.Rømer;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Types.Rømer;
using Xunit;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<RømerDouble, double>
{
    public ToDoubleExtensionTests() : base(999.9999d, GetData()) { }

    private static List<double> GetData()
    {
        return new List<double>
        {
            999.999d,
            0d,
            -999.999
        };
    }

    protected override double To(
        RømerDouble value,
        int fractionalCount)
    {
        return value.ToRømer(fractionalCount);
    }

    protected override double ToUsingGeneric(
        RømerDouble value,
        int fractionalCount)
    {
        return value.To<Rømer>(fractionalCount);
    }

    protected override RømerDouble Create(
        double value)
    {
        return new RømerDouble(value);
    }

    [Fact]
    public void Test_to_rømer_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rømer_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rømer_generic_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result =
            Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_to_rømer_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        GasDouble input = new(6);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        GasDouble input = new(6);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.5d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.49999999999999d;
        RankineDouble input = new(851.67);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 112.49999999999999d;
        RankineDouble input = new(851.67);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rømer_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerDouble input = new(851.67);

        // Act.
        double result = input.ToRømer();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rømer_generic_from_rømer_returns_correct_value()
    {
        // Arrange.
        RømerDouble input = new(851.67);

        // Act.
        double result = input.To<Rømer>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
