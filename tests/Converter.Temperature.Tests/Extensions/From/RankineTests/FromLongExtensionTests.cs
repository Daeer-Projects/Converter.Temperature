using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, RankineLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RankineLong ConvertFrom(
        long value)
    {
        return value.FromRankine();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        RankineLong result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
