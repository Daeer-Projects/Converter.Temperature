namespace Converter.Temperature.Tests.Extensions.To.Réaumur;

using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

public class ToStringTests
{
    [Fact]
    public void Test_ToRéaumur_With_No_Fractional_Count_Returns_Correct_Value()
    {
        // Arrange
        const string expected = "3.3";
        var input = new RéaumurString(expected);

        // Act
        var result = input.ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_ToRéaumur_With_Fractional_Count_Returns_Correct_Value()
    {
        // Arrange
        const string expected = "3.33";
        var input = new RéaumurString("3.333");

        // Act
        var result = input.ToRéaumur(2);

        // Assert
        result.Should().Be(expected);
    }
}
