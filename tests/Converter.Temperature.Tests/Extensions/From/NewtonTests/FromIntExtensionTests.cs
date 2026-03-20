using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromIntExtensionTests
{
    [Fact]
    public void Test_FromNewton_Returns_NewtonInt_Type()
    {
        // Arrange
        const int input = 10;

        // Act
        NewtonInt result = input.FromNewton();

        // Assert
        result.Should().BeOfType<NewtonInt>();
    }

    [Fact]
    public void Test_FromNewton_Returns_Correct_Value()
    {
        // Arrange
        const int input = 10;

        // Act
        NewtonInt result = input.FromNewton();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
