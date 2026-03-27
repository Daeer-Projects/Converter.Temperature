using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, RéaumurLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RéaumurLong ConvertFrom(
        long value)
    {
        return value.FromRéaumur();
    }

    [Fact]
    public void Test_from_réaumur_returns_réaumur_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        RéaumurLong result = input.FromRéaumur();

        // Assert.
        result.Should()
            .BeOfType<RéaumurLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
