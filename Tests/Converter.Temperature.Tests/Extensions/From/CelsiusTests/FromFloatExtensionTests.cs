namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, CelsiusFloat>
{
    public FromFloatExtensionTests() : base(float.MaxValue, 999.999f, 0f, -999.999f, float.MinValue) { }

    protected override CelsiusFloat ConvertFrom(
        float value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_celsius_returns_celsius_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        CelsiusFloat result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
