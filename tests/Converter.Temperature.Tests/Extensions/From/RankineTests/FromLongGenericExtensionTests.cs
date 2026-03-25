using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, RankineLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RankineLong ConvertFrom(
        long value)
    {
        return value.From<Rankine>() as RankineLong;
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
