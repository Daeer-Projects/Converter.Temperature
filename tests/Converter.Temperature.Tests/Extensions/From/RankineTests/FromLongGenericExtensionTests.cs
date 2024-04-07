namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rankine;
using Xunit;

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
