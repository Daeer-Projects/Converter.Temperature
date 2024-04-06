namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rankine;
using Xunit;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, RankineInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RankineInt ConvertFrom(
        int value)
    {
        return value.FromRankine();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        RankineInt result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
