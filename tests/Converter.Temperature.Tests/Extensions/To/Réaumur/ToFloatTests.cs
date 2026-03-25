using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

public class ToFloatTests
{
    [Fact]
    public void Test_ToRéaumur_With_No_Fractional_Count_Returns_Correct_Value()
    {
        // Arrange
        const float expected = 3.3f;
        RéaumurFloat input = new(expected);

        // Act
        float result = input.ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_ToRéaumur_With_Fractional_Count_Returns_Correct_Value()
    {
        // Arrange
        const float expected = 3.33f;
        RéaumurFloat input = new(3.333f);

        // Act
        float result = input.ToRéaumur(2);

        // Assert
        result.Should().Be(expected);
    }
}
