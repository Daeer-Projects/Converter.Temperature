using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromRømer
{
    [Theory]
    [InlineData("60", "33")]
    [InlineData("7.5", "0")]
    public void Test_string_extension_from_rømer_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
