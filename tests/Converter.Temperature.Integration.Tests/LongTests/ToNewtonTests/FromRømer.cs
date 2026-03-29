using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromRømer
{
    [Theory]
    [InlineData(60L, 33L)]
    [InlineData(7L, 0L)]
    public void Test_long_extension_from_rømer_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRømer().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
