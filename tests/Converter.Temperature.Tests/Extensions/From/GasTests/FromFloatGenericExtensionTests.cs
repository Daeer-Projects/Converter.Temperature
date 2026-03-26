using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Gas;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.GasTests;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, GasFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override GasFloat ConvertFrom(
        float value)
    {
        return value.From<Gas>() as GasFloat;
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
