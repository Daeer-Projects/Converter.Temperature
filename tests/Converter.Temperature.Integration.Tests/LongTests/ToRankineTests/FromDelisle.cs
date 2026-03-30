using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300L, 312L)]
    [InlineData(150L, 492L)]
    [InlineData(0L, 672L)]
    public void Test_long_extensions_from_delisle_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300L, 312L)]
    [InlineData(150L, 492L)]
    [InlineData(0L, 672L)]
    public void Test_long_extensions_generic_from_delisle_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Delisle>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
