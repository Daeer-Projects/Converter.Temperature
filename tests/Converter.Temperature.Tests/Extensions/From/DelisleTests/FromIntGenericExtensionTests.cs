using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, DelisleInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override DelisleInt ConvertFrom(
        int value)
    {
        return (DelisleInt)value.From<Delisle>();
    }

    [Fact]
    public void Test_from_delisle_generic_returns_delisle_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Delisle>();

        // Assert.
        result.Should()
            .BeOfType<DelisleInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
