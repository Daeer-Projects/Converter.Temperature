namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rømer;
using Xunit;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, RømerFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RømerFloat ConvertFrom(
        float value)
    {
        return value.From<Rømer>() as RømerFloat;
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
