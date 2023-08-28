namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Kelvin;
using Xunit;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, KelvinFloat>
{
    public FromFloatGenericExtensionTests() : base(float.MaxValue, 999.999f, 0f, -999.999f, float.MinValue) { }

    protected override KelvinFloat ConvertFrom(
        float value)
    {
        return value.From<Kelvin>() as KelvinFloat;
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
