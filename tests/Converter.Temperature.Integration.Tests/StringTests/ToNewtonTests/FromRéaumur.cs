using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromRéaumur
{
    [Theory]
    [InlineData("80", "33")]
    [InlineData("0", "0")]
    public void Test_string_extension_from_réaumur_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
