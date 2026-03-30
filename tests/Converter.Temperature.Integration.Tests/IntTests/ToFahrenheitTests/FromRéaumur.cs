using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, -148)]
    [InlineData(0, 32)]
    [InlineData(80, 212)]
    public void Test_int_extensions_from_réaumur_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, -148)]
    [InlineData(0, 32)]
    [InlineData(80, 212)]
    public void Test_int_extensions_generic_from_réaumur_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
