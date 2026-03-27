using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, RéaumurInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RéaumurInt ConvertFrom(
        int value)
    {
        return value.FromRéaumur();
    }

    [Fact]
    public void Test_from_réaumur_returns_réaumur_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        RéaumurInt result = input.FromRéaumur();

        // Assert.
        result.Should()
            .BeOfType<RéaumurInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
