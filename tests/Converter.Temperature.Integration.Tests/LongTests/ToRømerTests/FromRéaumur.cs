using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, -45L)]
    [InlineData(0L, 8L)]
    [InlineData(80L, 60L)]
    public void Test_long_extensions_from_réaumur_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, -45L)]
    [InlineData(0L, 8L)]
    [InlineData(80L, 60L)]
    public void Test_long_extensions_generic_from_réaumur_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
