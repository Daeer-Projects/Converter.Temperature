using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, RømerInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RømerInt ConvertFrom(
        int value)
    {
        return value.From<Rømer>() as RømerInt;
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
