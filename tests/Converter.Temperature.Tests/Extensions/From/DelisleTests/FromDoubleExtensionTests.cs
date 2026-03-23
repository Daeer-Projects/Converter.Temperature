using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, DelisleDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999,
        0,
        -999.999,
        double.MinValue) { }

    protected override DelisleDouble ConvertFrom(
        double value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_double_type()
    {
        // Arrange.
        const double input = 39.9d;

        // Act.
        DelisleDouble result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
