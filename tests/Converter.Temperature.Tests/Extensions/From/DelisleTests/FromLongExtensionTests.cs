using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, DelisleLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override DelisleLong ConvertFrom(
        long value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        DelisleLong result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
