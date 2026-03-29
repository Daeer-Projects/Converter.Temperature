using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000L, -428L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -121L)]
    [InlineData(100L, -107L)]
    [InlineData(500L, 10L)]
    [InlineData(1000L, 156L)]
    public void Test_long_extension_from_rankine_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -428L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -121L)]
    [InlineData(100L, -107L)]
    [InlineData(500L, 10L)]
    [InlineData(1000L, 156L)]
    public void Test_long_extension_generic_from_rankine_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
