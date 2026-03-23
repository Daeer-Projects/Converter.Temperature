using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public class ToIntTests
{
    [Fact]
    public void Test_ToRéaumur_Returns_Correct_Value()
    {
        // Arrange
        const int expected = 33;
        var input = new RéaumurInt(expected);

        // Act
        var result = input.ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }
}
