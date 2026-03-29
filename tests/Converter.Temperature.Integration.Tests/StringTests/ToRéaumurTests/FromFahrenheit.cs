using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRéaumurTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData("32", "0")]
    [InlineData("212", "80")]
    public void Test_string_extension_from_fahrenheit_to_réaumur_returns_correct_string_value(string input, string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
