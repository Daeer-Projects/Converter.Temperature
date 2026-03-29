using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000L, -2963L)]
    [InlineData(0L, 466L)]
    [InlineData(50L, 637L)]
    [InlineData(100L, 809L)]
    [InlineData(500L, 2180L)]
    [InlineData(1000L, 3895L)]
    public void Test_long_extension_from_rømer_and_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -2963L)]
    [InlineData(0L, 466L)]
    [InlineData(50L, 637L)]
    [InlineData(100L, 809L)]
    [InlineData(500L, 2180L)]
    [InlineData(1000L, 3895L)]
    public void Test_long_extension_generic_from_rømer_and_to_rankine_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
