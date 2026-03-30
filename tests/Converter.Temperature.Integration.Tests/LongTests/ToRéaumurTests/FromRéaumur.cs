using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, -80L)]
    [InlineData(0L, 0L)]
    [InlineData(80L, 80L)]
    public void Test_long_extensions_from_réaumur_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, -80L)]
    [InlineData(0L, 0L)]
    [InlineData(80L, 80L)]
    public void Test_long_extensions_generic_from_réaumur_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
