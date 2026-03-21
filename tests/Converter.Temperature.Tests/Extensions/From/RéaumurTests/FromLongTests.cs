namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

using Converter.Temperature.Extensions.From;
using Types.Réaumur;
using FluentAssertions;
using Xunit;

public class FromLongTests
{
    [Fact]
    public void Test_From_Newton_Long_Returns_RéaumurLong_Type()
    {
        // Arrange
        const long input = 33L;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurLong>();
    }

    [Fact]
    public void Test_From_Newton_Long_Returns_Correct_Value()
    {
        // Arrange
        const long input = 33L;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
