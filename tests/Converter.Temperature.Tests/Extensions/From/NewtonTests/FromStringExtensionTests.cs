using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromStringExtensionTests
{
    [Fact]
    public void Test_FromNewton_Returns_NewtonString_Type()
    {
        // Arrange
        const string input = "10";

        // Act
        NewtonString result = input.FromNewton();

        // Assert
        result.Should().BeOfType<NewtonString>();
    }

    [Fact]
    public void Test_FromNewton_Returns_Correct_Value()
    {
        // Arrange
        const string input = "10";

        // Act
        NewtonString result = input.FromNewton();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
