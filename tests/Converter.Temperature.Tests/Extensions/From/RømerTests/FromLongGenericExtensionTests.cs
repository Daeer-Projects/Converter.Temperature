namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rømer;
using Xunit;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, RømerLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RømerLong ConvertFrom(
        long value)
    {
        return value.From<Rømer>() as RømerLong;
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
