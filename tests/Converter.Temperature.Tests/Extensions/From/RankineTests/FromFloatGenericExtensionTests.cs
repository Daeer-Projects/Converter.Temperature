using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, RankineFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RankineFloat ConvertFrom(
        float value)
    {
        return value.From<Rankine>() as RankineFloat;
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
