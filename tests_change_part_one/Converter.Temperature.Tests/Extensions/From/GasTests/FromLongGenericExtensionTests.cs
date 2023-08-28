namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Gas;
using Xunit;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, GasLong>
{
    public FromLongGenericExtensionTests() : base(long.MaxValue, 999, 0, -999, long.MinValue) { }

    protected override GasLong ConvertFrom(
        long value)
    {
        return value.From<Gas>() as GasLong;
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
