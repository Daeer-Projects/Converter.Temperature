using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToLongTests
{
    [Fact]
    public void Test_to_réaumur_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        RéaumurLong input = new(expected);

        // Act.
        long result = input.ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
