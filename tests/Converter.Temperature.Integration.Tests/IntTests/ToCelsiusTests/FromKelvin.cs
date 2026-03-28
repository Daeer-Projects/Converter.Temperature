using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromKelvin
{
    [Fact]
    public void Test_int_extensions_from_kelvin_to_celsius_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 1;
        const int input = 274;

        // Act.
        int result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_kelvin_to_celsius_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 1;
        const int input = 274;

        // Act.
        int result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-2147483648, -2147483648)]
    [InlineData(2147483647, 2147483374)]
    public void Test_int_extension_from_kelvin_and_to_celsius_with_min_value_returns_correct_int_value(
        int input, int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromKelvin()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-2147483648, -2147483648)]
    [InlineData(2147483647, 2147483374)]
    public void Test_int_extension_generic_from_kelvin_and_to_celsius_with_min_value_returns_correct_int_value(
        int input, int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Kelvin>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
