namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Delisle;
using Xunit;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, DelisleInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override DelisleInt ConvertFrom(
        int value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        DelisleInt result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
