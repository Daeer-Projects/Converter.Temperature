using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(32L, 150L)]
    [InlineData(212L, 0L)]
    public void Test_long_extension_from_fahrenheit_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
