using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromRankine
{
    [Theory]
    [InlineData("671.67", "33")]
    [InlineData("491.67", "0")]
    public void Test_string_extension_from_rankine_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRankine().ToNewton(0);

        // Assert.
        result.Should().Be(expected);
    }
}
