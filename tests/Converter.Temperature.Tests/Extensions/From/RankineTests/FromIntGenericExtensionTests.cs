using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, RankineInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RankineInt ConvertFrom(
        int value)
    {
        return value.From<Rankine>() as RankineInt;
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
