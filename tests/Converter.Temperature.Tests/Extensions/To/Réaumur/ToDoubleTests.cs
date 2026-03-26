using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToDoubleTests
{
    [Fact]
    public void Test_to_réaumur_with_no_fractional_count_returns_correct_value()
    {
        // Arrange.
        const double expected = 3.3;
        RéaumurDouble input = new(expected);

        // Act.
        double result = input.ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_to_réaumur_with_fractional_count_returns_correct_value()
    {
        // Arrange.
        const double expected = 3.33;
        RéaumurDouble input = new(3.333);

        // Act.
        double result = input.ToRéaumur(2);

        // Assert.
        result.Should().Be(expected);
    }
}


