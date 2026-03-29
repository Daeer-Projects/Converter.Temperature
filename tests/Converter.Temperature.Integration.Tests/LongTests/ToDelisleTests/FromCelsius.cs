using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromCelsius
{
    [Theory]
    [InlineData(0L, 150L)]
    [InlineData(100L, 0L)]
    [InlineData(-100L, 300L)]
    public void Test_long_extension_from_celsius_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
