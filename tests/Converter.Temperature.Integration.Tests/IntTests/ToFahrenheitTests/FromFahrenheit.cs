using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_from_and_to_fahrenheit_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromFahrenheit()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-345)]
    [InlineData(0)]
    [InlineData(7564)]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_generic_from_and_to_fahrenheit_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
