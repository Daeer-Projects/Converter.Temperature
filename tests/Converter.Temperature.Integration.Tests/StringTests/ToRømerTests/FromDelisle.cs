using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromDelisle
{
    [Theory]
    [InlineData("300", "-45")]
    [InlineData("150", "7.5")]
    [InlineData("0", "60")]
    public void Test_string_extensions_from_delisle_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromDelisle()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("300", "-45")]
    [InlineData("150", "7.5")]
    [InlineData("0", "60")]
    public void Test_string_extensions_generic_from_delisle_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Delisle>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
