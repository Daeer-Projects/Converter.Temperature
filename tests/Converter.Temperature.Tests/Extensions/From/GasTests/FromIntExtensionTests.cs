namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Gas;
using Xunit;

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
