using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToFloatTests
{
    [Fact]
    public void Test_to_réaumur_with_no_fractional_count_returns_correct_value()
    {
        // Arrange.
        const float expected = 3.3f;
        RéaumurFloat input = new(expected);

        // Act.
        float result = input.ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_to_réaumur_with_fractional_count_returns_correct_value()
    {
        // Arrange.
        const float expected = 3.33f;
        RéaumurFloat input = new(3.333f);

        // Act.
        float result = input.ToRéaumur(2);

        // Assert.
        result.Should().Be(expected);
    }
}
