using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToStringTests
{
    [Fact]
    public void Test_to_réaumur_with_no_fractional_count_returns_correct_value()
    {
        // Arrange.
        const string expected = "3.3";
        RéaumurString input = new(expected);

        // Act.
        string result = input.ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_to_réaumur_with_fractional_count_returns_correct_value()
    {
        // Arrange.
        const string expected = "3.33";
        RéaumurString input = new("3.333");

        // Act.
        string result = input.ToRéaumur(2);

        // Assert.
        result.Should().Be(expected);
    }
}


