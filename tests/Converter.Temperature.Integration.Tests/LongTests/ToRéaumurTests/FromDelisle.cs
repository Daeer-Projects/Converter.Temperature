using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0L, 80L)]
    [InlineData(150L, 0L)]
    [InlineData(300L, -80L)]
    public void Test_long_extensions_from_delisle_to_réaumur_returns_correct_long_value(long input, long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromDelisle().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
