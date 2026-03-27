using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, RéaumurFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override RéaumurFloat ConvertFrom(
        float value)
    {
        return value.FromRéaumur();
    }

    [Fact]
    public void Test_from_réaumur_returns_réaumur_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        RéaumurFloat result = input.FromRéaumur();

        // Assert.
        result.Should()
            .BeOfType<RéaumurFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
