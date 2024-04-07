namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Kelvin;
using Xunit;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, KelvinFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override KelvinFloat ConvertFrom(
        float value)
    {
        return value.FromKelvin();
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        KelvinFloat result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
