using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromLongExtensionTests
{
    [Fact]
    public void Test_FromNewton_Returns_NewtonLong_Type()
    {
        // Arrange
        const long input = 10L;

        // Act
        NewtonLong result = input.FromNewton();

        // Assert
        result.Should().BeOfType<NewtonLong>();
    }

    [Fact]
    public void Test_FromNewton_Returns_Correct_Value()
    {
        // Arrange
        const long input = 10L;

        // Act
        NewtonLong result = input.FromNewton();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
