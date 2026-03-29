using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromRankine
{
    [Theory]
    [InlineData(492L, 150L)]
    [InlineData(672L, 0L)]
    public void Test_long_extension_from_rankine_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }
}
