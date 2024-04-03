namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rømer;
using Xunit;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, RømerLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override RømerLong ConvertFrom(
        long value)
    {
        return value.FromRømer();
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        RømerLong result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
