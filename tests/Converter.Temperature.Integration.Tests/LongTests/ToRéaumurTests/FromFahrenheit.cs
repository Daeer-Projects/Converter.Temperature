using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(32L, 0L)]
    [InlineData(212L, 80L)]
    public void Test_long_extension_from_fahrenheit_to_réaumur_returns_correct_long_value(long input, long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
