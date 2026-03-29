using System;
using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromGas
{
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
    public void
        Test_string_extensions_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
            string input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromGas()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }

    [Theory]
    [InlineData("0.24")]
    [InlineData("10.1")]
    public void
        Test_string_extensions_generic_from_gas_to_celsius_with_invalid_parameters_throws_argument_out_of_range_exception(
            string input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Gas>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low or too high for gas mark!");
    }
}
