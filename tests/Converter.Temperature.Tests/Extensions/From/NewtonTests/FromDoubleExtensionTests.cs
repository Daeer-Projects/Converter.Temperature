using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromDoubleExtensionTests
{
    [Fact]
    public void Test_FromNewton_Returns_NewtonDouble_Type()
    {
        // Arrange
        const double input = 10.0;

        // Act
        NewtonDouble result = input.FromNewton();

        // Assert
        result.Should().BeOfType<NewtonDouble>();
    }

    [Fact]
    public void Test_FromNewton_Returns_Correct_Value()
    {
        // Arrange
        const double input = 10.0;

        // Act
        NewtonDouble result = input.FromNewton();

        // Assert
        result.Temperature.Should().Be(input);
    }
}
