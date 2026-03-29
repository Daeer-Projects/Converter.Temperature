using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, NewtonLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override NewtonLong ConvertFrom(
        long value)
    {
        return value.FromNewton();
    }

    [Fact]
    public void Test_from_newton_returns_newton_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        NewtonLong result = input.FromNewton();

        // Assert.
        result.Should()
            .BeOfType<NewtonLong>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_newton_returns_correct_value()
    {
        // Arrange.
        const long input = 10L;

        // Act.
        NewtonLong result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
