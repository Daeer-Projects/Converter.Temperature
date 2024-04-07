namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rankine;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, RankineDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override RankineDouble ConvertFrom(
        double value)
    {
        return value.FromRankine();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        RankineDouble result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
