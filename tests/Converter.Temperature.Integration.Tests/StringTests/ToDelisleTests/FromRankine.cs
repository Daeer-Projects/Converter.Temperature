using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToDelisleTests;

public class FromRankine
{
    [Theory]
    [InlineData("491.67", "150")]
    [InlineData("671.67", "0")]
    public void Test_string_extension_from_rankine_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRankine()
            .ToDelisle();

        // Assert.
        double resultDouble = double.Parse(result);
        double expectedDouble = double.Parse(expected);
        resultDouble.Should()
            .BeApproximately(expectedDouble, 0.00000000001d);
    }
}
