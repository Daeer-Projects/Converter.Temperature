using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Gas;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.GasTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, GasInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override GasInt ConvertFrom(
        int value)
    {
        return value.From<Gas>() as GasInt;
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
