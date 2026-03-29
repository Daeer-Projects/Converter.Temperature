using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromRankine
{
    [Theory]
    [InlineData(672, 33)]
    [InlineData(492, 0)]
    public void Test_int_extension_from_rankine_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
