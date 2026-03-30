using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, 312)]
    [InlineData(150, 492)]
    [InlineData(0, 672)]
    public void Test_int_extensions_from_delisle_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, 312)]
    [InlineData(150, 492)]
    [InlineData(0, 672)]
    public void Test_int_extensions_generic_from_delisle_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
