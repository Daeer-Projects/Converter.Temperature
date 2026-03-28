using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromCelsius
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 80)]
    public void Test_int_extension_from_celsius_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromCelsius().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
