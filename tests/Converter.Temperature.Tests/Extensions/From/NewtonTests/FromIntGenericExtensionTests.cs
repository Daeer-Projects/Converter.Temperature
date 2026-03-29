using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, NewtonInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override NewtonInt ConvertFrom(
        int value)
    {
        return value.From<Newton>() as NewtonInt;
    }

    [Fact]
    public void Test_from_newton_generic_returns_newton_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Newton>();

        // Assert.
        result.Should()
            .BeOfType<NewtonInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
