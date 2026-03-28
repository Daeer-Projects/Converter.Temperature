using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 80)]
    public void Test_int_extension_from_fahrenheit_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromFahrenheit().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
