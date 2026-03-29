using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(50, 10)]
    [InlineData(int.MinValue, -1193046489)]
    [InlineData(int.MaxValue, 1193046453)]
    public void Test_int_extensions_from_fahrenheit_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(50, 10)]
    [InlineData(int.MinValue, -1193046489)]
    [InlineData(int.MaxValue, 1193046453)]
    public void Test_int_extensions_generic_from_fahrenheit_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
