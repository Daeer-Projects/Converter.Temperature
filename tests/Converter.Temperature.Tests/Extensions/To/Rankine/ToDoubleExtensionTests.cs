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

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<RankineDouble, double>
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
        RankineDouble value,
        int fractionalCount)
    {
        return value.ToRankine(fractionalCount);
    }

    protected override double ToUsingGeneric(
        RankineDouble value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Rankine>(fractionalCount);
    }

    protected override RankineDouble Create(
        double value)
    {
        return new RankineDouble(value);
    }

    [Fact]
    public void Test_to_rankine_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_rankine_generic_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        CelsiusDouble inputCelsius = new(input);

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
        const double expected = 851.6700000000001d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6700000000001d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        GasDouble input = new(6);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        GasDouble input = new(6);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_kelvin_returns_same_value()
    {
        // Arrange.
        const double expected = 851.67d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        const double expected = 851.67d;
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_rankine_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineDouble input = new(851.67);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_rankine_generic_from_rankine_returns_same_value()
    {
        // Arrange.
        RankineDouble input = new(851.67);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Theory]
    [InlineData(2157.8528571428574d, 493.47d)]
    [InlineData(1391.67d, 270d)]
    [InlineData(1193.67d, 212.25d)]
    [InlineData(1013.6700000000001d, 159.75d)]
    [InlineData(465.9557142857143d, 0d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(-10.4045142857143d, -138.9384d)]
    public void Test_to_rankine_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.8528571428574d, 493.47d)]
    [InlineData(1391.67d, 270d)]
    [InlineData(1193.67d, 212.25d)]
    [InlineData(1013.6700000000001d, 159.75d)]
    [InlineData(465.9557142857143d, 0d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(-10.4045142857143d, -138.9384d)]
    public void Test_to_rankine_generic_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.9d, 1)]
    [InlineData(2157.852857142857d, 12)]
    public void Test_to_rankine_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(2157.9d, 1)]
    [InlineData(2157.852857142857d, 12)]
    public void Test_to_rankine_generic_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.To<TemperatureTypes.Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
