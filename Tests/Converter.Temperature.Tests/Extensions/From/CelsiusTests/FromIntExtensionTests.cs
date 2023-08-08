namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, CelsiusInt>
{
    public FromIntExtensionTests() : base(int.MaxValue, 999, 0, -999, int.MinValue) { }

    protected override CelsiusInt ConvertFrom(
        int value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_celsius_returns_celsius_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        CelsiusInt result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
