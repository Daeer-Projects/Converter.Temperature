using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33, 312)]
    [InlineData(0, 492)]
    [InlineData(33, 672)]
    public void Test_int_extensions_from_newton_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromNewton()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33, 312)]
    [InlineData(0, 492)]
    [InlineData(33, 672)]
    public void Test_int_extensions_generic_from_newton_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
