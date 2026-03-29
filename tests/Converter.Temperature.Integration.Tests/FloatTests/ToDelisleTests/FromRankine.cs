using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromRankine
{
    [Theory]
    [InlineData(491.67f, 150f)]
    [InlineData(671.67f, 0f)]
    public void Test_float_extension_from_rankine_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.001f);
    }
}
