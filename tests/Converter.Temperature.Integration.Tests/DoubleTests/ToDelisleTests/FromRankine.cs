using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToDelisleTests;

public class FromRankine
{
    [Theory]
    [InlineData(491.67d, 150d)]
    [InlineData(671.67d, 0d)]
    public void Test_double_extension_from_rankine_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRankine()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.00000000001d);
    }
}
