using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromFloatTests
{
    [Fact]
    public void Test_From_Newton_Float_Returns_RéaumurFloat_Type()
    {
        // Arrange
        const float input = 3.3f;

        // Act
        RéaumurFloat result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurFloat>();
    }

    [Fact]
    public void Test_From_Newton_Float_Returns_Correct_Value()
    {
        // Arrange
        const float input = 3.3f;

        // Act
        RéaumurFloat result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}

