using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(80L, 33L)]
    [InlineData(0L, 0L)]
    public void Test_long_extension_from_réaumur_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
