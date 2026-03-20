namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

public class FromStringTests
{
    [Fact]
    public void Test_From_Newton_String_Returns_RéaumurString_Type()
    {
        // Arrange
        const string input = "33";

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurString>();
    }

    [Fact]
    public void Test_From_Newton_String_Returns_Correct_Value()
    {
        // Arrange
        const string input = "33";

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
