using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromKelvin
{
    [Fact]
    public void Test_int_extensions_from_kelvin_to_fahrenheit_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 34;
        const int input = 274;

        // Act.
        int result = input.FromKelvin()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_kelvin_to_fahrenheit_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 34;
        const int input = 274;

        // Act.
        int result = input.From<Kelvin>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-2147483648)]
    [InlineData(2147483647)]
    public void Test_int_extension_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_int_value(
        int input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.FromKelvin()
            .ToFahrenheit();
    }

    [Theory]
    [InlineData(-2147483648)]
    [InlineData(2147483647)]
    public void Test_int_extension_generic_from_kelvin_and_to_fahrenheit_with_invalid_value_returns_correct_int_value(
        int input)
    {
        // Arrange.
        // Act.
        // Assert.
        input.From<Kelvin>()
            .To<Fahrenheit>();
    }
}
