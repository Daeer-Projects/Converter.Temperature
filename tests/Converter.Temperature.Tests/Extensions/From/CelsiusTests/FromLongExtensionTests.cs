namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, CelsiusLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override CelsiusLong ConvertFrom(
        long value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_celsius_returns_celsius_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        CelsiusLong result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
