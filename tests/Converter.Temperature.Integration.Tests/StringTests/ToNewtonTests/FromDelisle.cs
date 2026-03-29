using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromDelisle
{
    [Theory]
    [InlineData("0", "33")]
    [InlineData("150", "0")]
    public void Test_string_extension_from_delisle_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
