namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

using Converter.Temperature.Extensions.From;
using Types.Réaumur;
using FluentAssertions;
using Xunit;

public class FromFloatTests
{
    [Fact]
    public void Test_From_Newton_Float_Returns_RéaumurFloat_Type()
    {
        // Arrange
        const float input = 3.3f;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurFloat>();
    }

    [Fact]
    public void Test_From_Newton_Float_Returns_Correct_Value()
    {
        // Arrange
        const float input = 3.3f;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
