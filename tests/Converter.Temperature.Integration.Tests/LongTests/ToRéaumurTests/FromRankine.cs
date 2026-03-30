using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromRankine
{
    [Theory]
    [InlineData(312L, -80L)]
    [InlineData(492L, 0L)]
    [InlineData(672L, 80L)]
    public void Test_long_extensions_from_rankine_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRankine()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(312L, -80L)]
    [InlineData(492L, 0L)]
    [InlineData(672L, 80L)]
    public void Test_long_extensions_generic_from_rankine_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Rankine>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
