using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public class ToLongTests
{
    [Fact]
    public void Test_ToRéaumur_Returns_Correct_Value()
    {
        // Arrange
        const long expected = 33L;
        var input = new RéaumurLong(expected);

        // Act
        var result = input.ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }
}
