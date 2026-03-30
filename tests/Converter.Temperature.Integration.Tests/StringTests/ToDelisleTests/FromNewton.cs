using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToDelisleTests;

public class FromNewton
{
    [Theory]
    [InlineData("-33", "300")]
    [InlineData("0", "150")]
    [InlineData("33", "0")]
    public void Test_string_extensions_from_newton_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromNewton()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("-33", "300")]
    [InlineData("0", "150")]
    [InlineData("33", "0")]
    public void Test_string_extensions_generic_from_newton_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.From<Newton>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
