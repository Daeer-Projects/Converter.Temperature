namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Gas;
using Xunit;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, GasFloat>
{
    public FromFloatExtensionTests() : base(float.MaxValue, 999.999f, 0f, -999.999f, float.MinValue) { }

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
