namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Types.Gas;
using Xunit;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, GasLong>
{
    public FromLongExtensionTests() : base(long.MaxValue, 999, 0, -999, long.MinValue) { }

    protected override GasLong ConvertFrom(
        long value)
    {
        return value.FromGas();
    }

    [Fact]
    public void Test_from_gas_returns_gas_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        GasLong result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
