using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, NewtonInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override NewtonInt ConvertFrom(
        int value)
    {
        return value.FromNewton();
    }

    [Fact]
    public void Test_from_newton_returns_newton_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        NewtonInt result = input.FromNewton();

        // Assert.
        result.Should()
            .BeOfType<NewtonInt>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_newton_returns_correct_value()
    {
        // Arrange.
        const int input = 10;

        // Act.
        NewtonInt result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
