namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

public class FromIntTests
{
    [Fact]
    public void Test_From_Newton_Int_Returns_RéaumurInt_Type()
    {
        // Arrange
        const int input = 33;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Should().BeOfType<RéaumurInt>();
    }

    [Fact]
    public void Test_From_Newton_Int_Returns_Correct_Value()
    {
        // Arrange
        const int input = 33;

        // Act
        var result = input.FromRéaumur();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
