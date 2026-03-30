using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromDelisle
{
    [Theory]
    [InlineData("300", "173.14999999999998")]
    [InlineData("150", "273.15")]
    [InlineData("0", "373.15")]
    public void Test_string_extensions_from_delisle_to_kelvin_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("300", "173.14999999999998")]
    [InlineData("150", "273.15")]
    [InlineData("0", "373.15")]
    public void Test_string_extensions_generic_from_delisle_to_kelvin_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
