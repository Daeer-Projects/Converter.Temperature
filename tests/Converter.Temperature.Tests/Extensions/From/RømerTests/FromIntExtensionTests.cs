namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rømer;
using Xunit;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, RømerInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RømerInt ConvertFrom(
        int value)
    {
        return value.FromRømer();
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        RømerInt result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
