using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Gas;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.GasTests;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, GasInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override GasInt ConvertFrom(
        int value)
    {
        return value.FromGas();
    }

    [Fact]
    public void Test_from_gas_returns_gas_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        GasInt result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
