using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, RéaumurLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RéaumurLong ConvertFrom(
        long value)
    {
        return value.From<Réaumur>() as RéaumurLong;
    }

    [Fact]
    public void Test_from_réaumur_generic_returns_réaumur_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Réaumur>();

        // Assert.
        result.Should()
            .BeOfType<RéaumurLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
