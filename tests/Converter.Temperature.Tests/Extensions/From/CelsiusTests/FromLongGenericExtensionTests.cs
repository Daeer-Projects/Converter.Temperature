using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Celsius;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, CelsiusLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override CelsiusLong ConvertFrom(
        long value)
    {
        return value.From<Celsius>() as CelsiusLong;
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
