using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, -100)]
    [InlineData(0, 0)]
    [InlineData(80, 100)]
    public void Test_int_extensions_from_réaumur_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, -100)]
    [InlineData(0, 0)]
    [InlineData(80, 100)]
    public void Test_int_extensions_generic_from_réaumur_to_celsius_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
