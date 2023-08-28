namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Xunit;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, CelsiusFloat>
{
    public FromFloatGenericExtensionTests() : base(float.MaxValue, 999.999f, 0f, -999.999f, float.MinValue) { }

    protected override CelsiusFloat ConvertFrom(
        float value)
    {
        return value.From<Celsius>() as CelsiusFloat;
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
