using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, -100)]
    [InlineData(150, 0)]
    [InlineData(0, 100)]
    public void Test_int_extensions_from_delisle_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, -100)]
    [InlineData(150, 0)]
    [InlineData(0, 100)]
    public void Test_int_extensions_generic_from_delisle_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
