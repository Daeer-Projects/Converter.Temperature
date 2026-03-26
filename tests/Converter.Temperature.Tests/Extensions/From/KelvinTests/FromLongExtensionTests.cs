using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Kelvin;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, KelvinLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override KelvinLong ConvertFrom(
        long value)
    {
        return value.FromKelvin();
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        KelvinLong result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
