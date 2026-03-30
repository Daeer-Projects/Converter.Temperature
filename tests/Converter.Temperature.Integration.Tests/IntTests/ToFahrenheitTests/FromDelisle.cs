using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, -148)]
    [InlineData(150, 32)]
    [InlineData(0, 212)]
    public void Test_int_extensions_from_delisle_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, -148)]
    [InlineData(150, 32)]
    [InlineData(0, 212)]
    public void Test_int_extensions_generic_from_delisle_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
