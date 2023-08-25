namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using System.Globalization;
using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, CelsiusString>
{
    public FromStringExtensionTests() : base(double.MaxValue.ToString(CultureInfo.InvariantCulture), "999.999", "0", "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override CelsiusString ConvertFrom(
        string value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_celsius_returns_celsius_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        CelsiusString result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
