using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRømerTests;

public class FromNewton
{
    [Theory]
    [InlineData("-33", "-45")]
    [InlineData("0", "7.5")]
    [InlineData("33", "60")]
    public void Test_string_extensions_from_newton_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-33", "-45")]
    [InlineData("0", "7.5")]
    [InlineData("33", "60")]
    public void Test_string_extensions_generic_from_newton_to_rømer_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
