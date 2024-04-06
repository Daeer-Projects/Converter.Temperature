namespace Converter.Temperature.Integration.Tests.DoubleTests;

using System;
using Extensions.From;
using Extensions.To;
using Extensions.To.Rankine;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToRankineDoubleTests
{
    #region From Celsius

    [Fact]
    public void Test_double_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6699999999998d;
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6699999999998d;
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6699999999998d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_with_parameter_from_celsius_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 200d;

        // Act.
        double result = input.FromCelsius()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6699999999998d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_generic_with_parameter_from_celsius_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 200d;

        // Act.
        double result = input.From<Celsius>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromCelsius()
                .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_double_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Celsius>()
                .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_double_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6700000000001d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6700000000001d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6700000000001d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6700000000001d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extensions_generic_with_parameter_from_fahrenheit_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_double_extension_from_kelvin_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -1800d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 90d)]
    [InlineData(1000d, 1800d)]
    public void Test_double_extension_generic_from_kelvin_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_double_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6699999999998d;
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_double_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.6699999999998d;
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6699999999998d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extension_with_parameter_from_gas_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(851.6699999999998d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extension_generic_with_parameter_from_gas_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_and_to_rankine_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_generic_from_and_to_rankine_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(-1000d, -2962.615714285714d)]
    [InlineData(0d, 465.9557142857143d)]
    [InlineData(50d, 637.3842857142857d)]
    [InlineData(100d, 808.8128571428572d)]
    [InlineData(500d, 2180.2414285714285d)]
    [InlineData(1000d, 3894.5271428571427d)]
    public void Test_double_extension_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d)]
    [InlineData(0d, 465.9557142857143d)]
    [InlineData(50d, 637.3842857142857d)]
    [InlineData(100d, 808.8128571428572d)]
    [InlineData(500d, 2180.2414285714285d)]
    [InlineData(1000d, 3894.5271428571427d)]
    public void Test_double_extension_generic_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d, -1)]
    [InlineData(0d, 465.9557142857143d, -1)]
    [InlineData(50d, 637.3842857142857d, -1)]
    [InlineData(100d, 808.8128571428572d, -1)]
    [InlineData(500d, 2180.2414285714285d, -1)]
    [InlineData(1000d, 3894.5271428571427d, -1)]
    [InlineData(-1000d, -2963d, 0)]
    [InlineData(0d, 466d, 0)]
    [InlineData(50d, 637d, 0)]
    [InlineData(100d, 809d, 0)]
    [InlineData(500d, 2180d, 0)]
    [InlineData(1000d, 3895d, 0)]
    [InlineData(-1000d, -2962.6d, 1)]
    [InlineData(0d, 465.9557142857143d, 13)]
    [InlineData(50d, 637.3843d, 4)]
    [InlineData(100d, 808.8d, 1)]
    [InlineData(500d, 2180.2414286d, 7)]
    [InlineData(1000d, 3894.527142857143d, 14)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRømer()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000d, -2962.615714285714d, -1)]
    [InlineData(0d, 465.9557142857143d, -1)]
    [InlineData(50d, 637.3842857142857d, -1)]
    [InlineData(100d, 808.8128571428572d, -1)]
    [InlineData(500d, 2180.2414285714285d, -1)]
    [InlineData(1000d, 3894.5271428571427d, -1)]
    [InlineData(-1000d, -2963d, 0)]
    [InlineData(0d, 466d, 0)]
    [InlineData(50d, 637d, 0)]
    [InlineData(100d, 809d, 0)]
    [InlineData(500d, 2180d, 0)]
    [InlineData(1000d, 3895d, 0)]
    [InlineData(-1000d, -2962.6d, 1)]
    [InlineData(0d, 465.9557142857143d, 13)]
    [InlineData(50d, 637.3843d, 4)]
    [InlineData(100d, 808.8d, 1)]
    [InlineData(500d, 2180.2414286d, 7)]
    [InlineData(1000d, 3894.527142857143d, 14)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_rankine_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rømer>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rømer
}
