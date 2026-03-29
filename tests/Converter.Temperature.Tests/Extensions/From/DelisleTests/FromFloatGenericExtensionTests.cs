using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, DelisleFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override DelisleFloat ConvertFrom(
        float value)
    {
        return value.From<Delisle>() as DelisleFloat;
    }

    [Fact]
    public void Test_from_delisle_generic_returns_delisle_float_type()
    {
        // Arrange.
        const float input = 39.9f;

        // Act.
        FloatBase result = input.From<Delisle>();

        // Assert.
        result.Should()
            .BeOfType<DelisleFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
