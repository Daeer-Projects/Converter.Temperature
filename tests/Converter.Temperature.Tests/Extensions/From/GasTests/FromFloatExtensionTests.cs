using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Gas;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.GasTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, GasFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override GasFloat ConvertFrom(
        float value)
    {
        return value.FromGas();
    }

    [Fact]
    public void Test_from_gas_returns_gas_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        GasFloat result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
