using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToIntTests
{
    [Fact]
    public void Test_to_réaumur_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        RéaumurInt input = new(expected);

        // Act.
        int result = input.ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
