using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public class FromLongGenericExtensionTests : BaseFromExtensionTests<long, NewtonLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override NewtonLong ConvertFrom(
        long value)
    {
        return value.From<Newton>() as NewtonLong;
    }

    [Fact]
    public void Test_from_newton_generic_returns_newton_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Newton>();

        // Assert.
        result.Should()
            .BeOfType<NewtonLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
