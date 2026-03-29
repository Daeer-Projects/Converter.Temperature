using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromRankine
{
    [Theory]
    [InlineData(672L, 33L)]
    [InlineData(492L, 0L)]
    public void Test_long_extension_from_rankine_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
