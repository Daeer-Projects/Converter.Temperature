using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromCelsius
{
    [Theory]
    [InlineData(100L, 33L)]
    [InlineData(0L, 0L)]
    [InlineData(-33L, -11L)]
    public void Test_long_extension_from_celsius_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
