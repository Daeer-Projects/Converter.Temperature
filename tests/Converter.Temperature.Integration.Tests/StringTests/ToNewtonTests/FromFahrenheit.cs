using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData("212", "33")]
    [InlineData("32", "0")]
    public void Test_string_extension_from_fahrenheit_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
