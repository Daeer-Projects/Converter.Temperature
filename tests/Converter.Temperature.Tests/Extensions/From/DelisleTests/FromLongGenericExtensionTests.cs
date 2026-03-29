using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, DelisleLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override DelisleLong ConvertFrom(
        long value)
    {
        return value.From<Delisle>() as DelisleLong;
    }

    [Fact]
    public void Test_from_delisle_generic_returns_delisle_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Delisle>();

        // Assert.
        result.Should()
            .BeOfType<DelisleLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
