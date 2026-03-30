using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData("-33", "173.14999999999998")]
    [InlineData("0", "273.15")]
    [InlineData("33", "373.15")]
    public void Test_string_extensions_from_newton_to_kelvin_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-33", "173.14999999999998")]
    [InlineData("0", "273.15")]
    [InlineData("33", "373.15")]
    public void Test_string_extensions_generic_from_newton_to_kelvin_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
