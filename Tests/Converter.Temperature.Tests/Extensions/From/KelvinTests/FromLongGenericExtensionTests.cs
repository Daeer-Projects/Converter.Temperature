namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Types.Kelvin;
using Xunit;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, KelvinLong>
{
    public FromLongGenericExtensionTests() : base(long.MaxValue, 999, 0, -999, long.MinValue) { }

    protected override KelvinLong ConvertFrom(
        long value)
    {
        return value.From<Kelvin>() as KelvinLong;
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
