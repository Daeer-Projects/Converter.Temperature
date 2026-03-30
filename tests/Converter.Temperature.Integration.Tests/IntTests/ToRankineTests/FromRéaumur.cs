using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, 312)]
    [InlineData(0, 492)]
    [InlineData(80, 672)]
    public void Test_int_extensions_from_réaumur_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, 312)]
    [InlineData(0, 492)]
    [InlineData(80, 672)]
    public void Test_int_extensions_generic_from_réaumur_to_rankine_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
