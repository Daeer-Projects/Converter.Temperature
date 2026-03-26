using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, RømerFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RømerFloat ConvertFrom(
        float value)
    {
        return value.FromRømer();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        RømerFloat result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
