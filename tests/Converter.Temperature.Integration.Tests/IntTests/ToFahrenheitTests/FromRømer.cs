using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000, -3422)]
    [InlineData(0, 6)]
    [InlineData(50, 178)]
    [InlineData(100, 349)]
    [InlineData(500, 1721)]
    [InlineData(1000, 3435)]
    public void Test_int_extension_from_rømer_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -3422)]
    [InlineData(0, 6)]
    [InlineData(50, 178)]
    [InlineData(100, 349)]
    [InlineData(500, 1721)]
    [InlineData(1000, 3435)]
    public void Test_int_extension_generic_from_rømer_and_to_fahrenheit_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
