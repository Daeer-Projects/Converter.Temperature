using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromFloatExtensionTests
{
    [Fact]
    public void Test_FromNewton_Returns_NewtonFloat_Type()
    {
        // Arrange.
        const float input = 10.0f;

        // Act.
        NewtonFloat result = input.FromNewton();

        // Assert.
        result.Should().BeOfType<NewtonFloat>();
    }

    [Fact]
    public void Test_FromNewton_Returns_Correct_Value()
    {
        // Arrange.
        const float input = 10.0f;

        // Act.
        NewtonFloat result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
