namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rømer;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, RømerDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override RømerDouble ConvertFrom(
        double value)
    {
        return value.FromRømer();
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        RømerDouble result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
