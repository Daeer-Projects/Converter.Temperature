using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, RéaumurFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RéaumurFloat ConvertFrom(
        float value)
    {
        return value.From<Réaumur>() as RéaumurFloat;
    }

    [Fact]
    public void Test_from_réaumur_generic_returns_réaumur_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Réaumur>();

        // Assert.
        result.Should()
            .BeOfType<RéaumurFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
