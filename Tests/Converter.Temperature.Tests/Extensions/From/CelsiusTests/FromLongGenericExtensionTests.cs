namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Xunit;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, CelsiusLong>
{
    public FromLongGenericExtensionTests() : base(long.MaxValue, 999, 0, -999, long.MinValue) { }

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
