using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, NewtonFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override NewtonFloat ConvertFrom(
        float value)
    {
        return value.FromNewton();
    }

    [Fact]
    public void Test_from_newton_returns_newton_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        NewtonFloat result = input.FromNewton();

        // Assert.
        result.Should()
            .BeOfType<NewtonFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_newton_returns_Correct_Value()
    {
        // Arrange.
        const float input = 10.0f;

        // Act.
        NewtonFloat result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
