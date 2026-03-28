using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromCelsius
{
    [Theory]
    [InlineData(0, 150)]
    [InlineData(100, 0)]
    [InlineData(-100, 300)]
    public void Test_int_extension_from_celsius_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, 150)]
    [InlineData(100, 0)]
    public void Test_int_extension_generic_from_celsius_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Celsius>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
