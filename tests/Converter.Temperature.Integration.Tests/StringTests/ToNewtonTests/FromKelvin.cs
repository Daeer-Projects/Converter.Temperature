using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToNewtonTests;

public class FromKelvin
{
    [Theory]
    [InlineData("373.15", "33")]
    [InlineData("273.15", "0")]
    public void Test_string_extension_from_kelvin_to_newton_returns_correct_string_value(string input, string expected)
    {
        // Arrange.

        // Act.
        string result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
