using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(80L, 672L)]
    public void Test_long_extensions_from_réaumur_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(80L, 672L)]
    public void Test_long_extensions_generic_from_réaumur_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
