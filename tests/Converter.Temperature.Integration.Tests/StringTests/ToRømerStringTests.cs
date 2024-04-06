namespace Converter.Temperature.Integration.Tests.StringTests;

using System;
using System.Globalization;
using Extensions.From;
using Extensions.To;
using Extensions.To.Rømer;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToRømerStringTests
{
    #region From Celsius

    [Fact]
    public void Test_string_extensions_from_celsius_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "200";

        // Act.
        string result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_celsius_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "200";

        // Act.
        string result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_string_extensions_with_parameter_from_celsius_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "203";

        // Act.
        string result = input.FromCelsius()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(114.075d, -1)]
    [InlineData(114d, 0)]
    [InlineData(114.08d, 2)]
    public void Test_string_extensions_generic_with_parameter_from_celsius_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "203";

        // Act.
        string result = input.From<Celsius>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.ToString(CultureInfo.InvariantCulture)
                .FromCelsius()
                .ToRømer());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_generic_from_celsius_to_rømer_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.ToString(CultureInfo.InvariantCulture)
                .From<Celsius>()
                .To<Rømer>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_string_extensions_from_fahrenheit_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "392";

        // Act.
        string result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_fahrenheit_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "392";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_string_extensions_with_parameter_from_fahrenheit_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "392.94";

        // Act.
        string result = input.FromFahrenheit()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_string_extensions_generic_with_parameter_from_fahrenheit_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "392.94";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000d, -660.9037500000001d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -109.65374999999999d)]
    [InlineData(1000d, 389.09625d)]
    public void Test_string_extension_from_kelvin_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -660.9037500000001d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -109.65374999999999d)]
    [InlineData(1000d, 389.09625d)]
    public void Test_string_extension_generic_from_kelvin_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_string_extension_from_gas_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "6";

        // Act.
        string result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_gas_to_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "112.5";
        const string input = "6";

        // Act.
        string result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_string_extension_with_parameter_from_gas_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "6";

        // Act.
        string result = input.FromGas()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_string_extension_generic_with_parameter_from_gas_to_rømer_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const string input = "6";

        // Act.
        string result = input.From<Gas>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000d, -427.5704166666667d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -121.32041666666666d)]
    [InlineData(100d, -106.73708333333333d)]
    [InlineData(500d, 9.929583333333328d)]
    [InlineData(1000d, 155.76291666666665d)]
    public void Test_string_extension_from_rankine_and_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -121.32041666666666d)]
    [InlineData(100d, -106.73708333333333d)]
    [InlineData(500d, 9.929583333333328d)]
    [InlineData(1000d, 155.76291666666665d)]
    public void Test_string_extension_generic_from_rankine_and_to_rømer_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d, -1)]
    [InlineData(0d, -135.90375d, -1)]
    [InlineData(50d, -121.32041666666666d, -1)]
    [InlineData(100d, -106.73708333333333d, -1)]
    [InlineData(500d, 9.929583333333328d, -1)]
    [InlineData(1000d, 155.76291666666665d, -1)]
    [InlineData(-1000d, -428d, 0)]
    [InlineData(0d, -136d, 0)]
    [InlineData(50d, -121d, 0)]
    [InlineData(100d, -107d, 0)]
    [InlineData(500d, 10d, 0)]
    [InlineData(1000d, 156d, 0)]
    [InlineData(-1000d, -427.6d, 1)]
    [InlineData(0d, -135.90375d, 13)]
    [InlineData(50d, -121.3204d, 4)]
    [InlineData(100d, -106.7d, 1)]
    [InlineData(500d, 9.9295833d, 7)]
    [InlineData(1000d, 155.76291666666665d, 14)]
    public void Test_string_extension_with_parameter_from_rankine_and_to_rømer_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToRømer(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(-1000d, -427.5704166666667d, -1)]
    [InlineData(0d, -135.90375d, -1)]
    [InlineData(50d, -121.32041666666666d, -1)]
    [InlineData(100d, -106.73708333333333d, -1)]
    [InlineData(500d, 9.929583333333328d, -1)]
    [InlineData(1000d, 155.76291666666665d, -1)]
    [InlineData(-1000d, -428d, 0)]
    [InlineData(0d, -136d, 0)]
    [InlineData(50d, -121d, 0)]
    [InlineData(100d, -107d, 0)]
    [InlineData(500d, 10d, 0)]
    [InlineData(1000d, 156d, 0)]
    [InlineData(-1000d, -427.6d, 1)]
    [InlineData(0d, -135.90375d, 13)]
    [InlineData(50d, -121.3204d, 4)]
    [InlineData(100d, -106.7d, 1)]
    [InlineData(500d, 9.9295833d, 7)]
    [InlineData(1000d, 155.76291666666665d, 14)]
    public void Test_string_extension_generic_with_parameter_from_rankine_and_to_rømer_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Rømer>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_from_and_to_rømer_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRømer()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(value.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_generic_from_and_to_rømer_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Rømer
}
