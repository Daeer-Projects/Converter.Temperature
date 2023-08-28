namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, CelsiusDouble>
{
    public FromDoubleExtensionTests() : base(double.MaxValue, 999.999d, 0d, -999.999d, double.MinValue) { }

    protected override CelsiusDouble ConvertFrom(
        double value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_celsius_returns_celsius_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        CelsiusDouble result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
