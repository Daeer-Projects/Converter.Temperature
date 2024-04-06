namespace Converter.Temperature.Integration.Tests.StringTests;

using System;
using System.Globalization;
using Extensions.From;
using Extensions.To;
using Extensions.To.Celsius;
using FluentAssertions;
using TemperatureTypes;
using Xunit;

public sealed class ToCelsiusStringTests
{
    #region From Celsius

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(-345.65d)]
    [InlineData(0.0d)]
    [InlineData(7564.2334d)]
    [InlineData(double.MaxValue)]
    public void Test_string_extension_from_and_to_celsius_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromCelsius()
            .ToCelsius();

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
    public void Test_string_extension_generic_from_and_to_celsius_returns_correct_string_value(
        double value)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Celsius

    #region From Fahrenheit

    [Fact]
    public void Test_string_extension_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromFahrenheit()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_string_extension_generic_from_fahrenheit_and_to_celsius_with_min_value_throws_exception()
    {
        // Arrange.
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Fahrenheit>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Fact]
    public void Test_string_extensions_from_fahrenheit_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "10";
        const string input = "50";

        // Act.
        string result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_fahrenheit_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "10";
        const string input = "50";

        // Act.
        string result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Kelvin

    [Fact]
    public void Test_string_extensions_from_kelvin_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "1";
        const string input = "274.15";

        // Act.
        string result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_kelvin_to_celsius_returns_correct_string_value()
    {
        // Arrange.
        const string expected = "1";
        const string input = "274.15";

        // Act.
        string result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
    {
        // Arrange.
        string expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        string result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_string_value()
    {
        // Arrange.
        string expected = double.MinValue.ToString(CultureInfo.InvariantCulture);
        string input = double.MinValue.ToString(CultureInfo.InvariantCulture);

        // Act.
        string result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Theory]
    [InlineData(0.25d, 125d)]
    [InlineData(0.9d, 125d)]
    [InlineData(1d, 140d)]
    [InlineData(1.4d, 140d)]
    [InlineData(1.5d, 150d)]
    [InlineData(2.4d, 150d)]
    [InlineData(2.5d, 165d)]
    [InlineData(3.4d, 165d)]
    [InlineData(3.5d, 180d)]
    [InlineData(4.4d, 180d)]
    [InlineData(4.5d, 190d)]
    [InlineData(5.4d, 190d)]
    [InlineData(5.5d, 200d)]
    [InlineData(6.4d, 200d)]
    [InlineData(6.5d, 220d)]
    [InlineData(7.4d, 220d)]
    [InlineData(7.5d, 230d)]
    [InlineData(8.4d, 230d)]
    [InlineData(8.5d, 240d)]
    [InlineData(9.4d, 240d)]
    [InlineData(9.5d, 260d)]
    [InlineData(9.9d, 260d)]
    public void Test_string_extensions_from_gas_to_celsius_returns_correct_string_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        string result = input.ToString(CultureInfo.InvariantCulture)
            .FromGas()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0.25d, 125d)]
    [InlineData(0.9d, 125d)]
    [InlineData(1d, 140d)]
    [InlineData(1.4d, 140d)]
    [InlineData(1.5d, 150d)]
    [InlineData(2.4d, 150d)]
    [InlineData(2.5d, 165d)]
    [InlineData(3.4d, 165d)]
    [InlineData(3.5d, 180d)]
    [InlineData(4.4d, 180d)]
    [InlineData(4.5d, 190d)]
    [InlineData(5.4d, 190d)]
    [InlineData(5.5d, 200d)]
    [InlineData(6.4d, 200d)]
    [InlineData(6.5d, 220d)]
    [InlineData(7.4d, 220d)]
    [InlineData(7.5d, 230d)]
    [InlineData(8.4d, 230d)]
    [InlineData(8.5d, 240d)]
    [InlineData(9.4d, 240d)]
    [InlineData(9.5d, 260d)]
    [InlineData(9.9d, 260d)]
    public void Test_string_extensions_generic_from_gas_to_celsius_returns_correct_string_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        string result = input.ToString(CultureInfo.InvariantCulture)
            .From<Gas>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.FromGas()
                .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void Test_string_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
        string input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(
            () => input.From<Gas>()
                .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(0, -273.15d)]
    [InlineData(50, -245.3722222222222d)]
    [InlineData(100, -217.59444444444446d)]
    [InlineData(500, 4.627777777777769d)]
    [InlineData(1000, 282.40555555555557d)]
    public void Test_string_extension_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d)]
    [InlineData(50, -245.3722222222222d)]
    [InlineData(100, -217.59444444444446d)]
    [InlineData(500, 4.627777777777769d)]
    [InlineData(1000, 282.40555555555557d)]
    public void Test_string_extension_generic_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d, -1)]
    [InlineData(50, -245.3722222222222d, -1)]
    [InlineData(100, -217.59444444444446d, -1)]
    [InlineData(500, 4.627777777777769d, -1)]
    [InlineData(1000, 282.40555555555557d, -1)]
    public void Test_string_extension_with_parameter_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRankine()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0, -273.15d, -1)]
    [InlineData(50, -245.3722222222222d, -1)]
    [InlineData(100, -217.59444444444446d, -1)]
    [InlineData(500, 4.627777777777769d, -1)]
    [InlineData(1000, 282.40555555555557d, -1)]
    public void Test_string_extension_generic_with_parameter_from_rankine_and_to_celsius_returns_correct_string_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rankine>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(0d, -14.285714285714286d)]
    [InlineData(50d, 80.95238095238095d)]
    [InlineData(100d, 176.1904761904762d)]
    [InlineData(500d, 938.0952380952381d)]
    [InlineData(1000d, 1890.4761904761904d)]
    public void Test_double_extension_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d)]
    [InlineData(50d, 80.95238095238095d)]
    [InlineData(100d, 176.1904761904762d)]
    [InlineData(500d, 938.0952380952381d)]
    [InlineData(1000d, 1890.4761904761904d)]
    public void Test_double_extension_generic_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d, -1)]
    [InlineData(50d, 80.95238095238095d, -1)]
    [InlineData(100d, 176.1904761904762d, -1)]
    [InlineData(500d, 938.0952380952381d, -1)]
    [InlineData(1000d, 1890.4761904761904d, -1)]
    [InlineData(0d, -14d, 0)]
    [InlineData(50d, 81d, 0)]
    [InlineData(100d, 176d, 0)]
    [InlineData(500d, 938d, 0)]
    [InlineData(1000d, 1890d, 0)]
    [InlineData(0d, -14.3d, 1)]
    [InlineData(50d, 80.95d, 2)]
    [InlineData(100d, 176.2d, 1)]
    [InlineData(500d, 938.0952380952381d, 14)]
    [InlineData(1000d, 1890.48d, 2)]
    public void Test_double_extension_with_parameter_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromRømer()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0d, -14.285714285714286d, -1)]
    [InlineData(50d, 80.95238095238095d, -1)]
    [InlineData(100d, 176.1904761904762d, -1)]
    [InlineData(500d, 938.0952380952381d, -1)]
    [InlineData(1000d, 1890.4761904761904d, -1)]
    [InlineData(0d, -14d, 0)]
    [InlineData(50d, 81d, 0)]
    [InlineData(100d, 176d, 0)]
    [InlineData(500d, 938d, 0)]
    [InlineData(1000d, 1890d, 0)]
    [InlineData(0d, -14.3d, 1)]
    [InlineData(50d, 80.95d, 2)]
    [InlineData(100d, 176.2d, 1)]
    [InlineData(500d, 938.0952380952381d, 14)]
    [InlineData(1000d, 1890.48d, 2)]
    public void Test_double_extension_generic_with_parameter_from_rømer_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Rømer>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    #endregion From Rømer
}
