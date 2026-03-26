using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, RankineFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RankineFloat ConvertFrom(
        float value)
    {
        return value.FromRankine();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        RankineFloat result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
