using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromRømer
{
    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    public void Test_int_extension_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    public void Test_int_extension_generic_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
