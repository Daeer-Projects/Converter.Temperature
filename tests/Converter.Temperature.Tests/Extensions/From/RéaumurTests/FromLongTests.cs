using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public class FromLongTests
{
    [Fact]
    public void Test_From_Newton_Long_Returns_RéaumurLong_Type()
    {
        // Arrange
        const long input = 33L;

        // Act
        RéaumurLong result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurLong>();
    }

    [Fact]
    public void Test_From_Newton_Long_Returns_Correct_Value()
    {
        // Arrange
        const long input = 33L;

        // Act
        RéaumurLong result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
