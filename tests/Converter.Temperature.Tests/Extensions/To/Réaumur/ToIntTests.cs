using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public sealed class ToIntTests
{
    [Fact]
    public void Test_ToRéaumur_Returns_Correct_Value()
    {
        // Arrange
        const int expected = 33;
        RéaumurInt input = new(expected);

        // Act
        int result = input.ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }
}

