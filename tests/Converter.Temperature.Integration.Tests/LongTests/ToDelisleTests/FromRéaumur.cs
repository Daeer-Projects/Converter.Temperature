using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80L, 300L)]
    [InlineData(0L, 150L)]
    [InlineData(80L, 0L)]
    public void Test_long_extensions_from_réaumur_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80L, 300L)]
    [InlineData(0L, 150L)]
    [InlineData(80L, 0L)]
    public void Test_long_extensions_generic_from_réaumur_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
