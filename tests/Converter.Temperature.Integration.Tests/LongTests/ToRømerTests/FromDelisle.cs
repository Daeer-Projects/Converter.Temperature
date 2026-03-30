using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300L, -45L)]
    [InlineData(150L, 8L)]
    [InlineData(0L, 60L)]
    public void Test_long_extensions_from_delisle_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300L, -45L)]
    [InlineData(150L, 8L)]
    [InlineData(0L, 60L)]
    public void Test_long_extensions_generic_from_delisle_to_rømer_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Delisle>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
