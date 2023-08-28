namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using System.Globalization;
using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Xunit;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, CelsiusString>
{
    public FromStringGenericExtensionTests() : base(double.MaxValue.ToString(CultureInfo.InvariantCulture), "999.999", "0",
        "-999.999", double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override CelsiusString ConvertFrom(
        string value)
    {
        return value.From<Celsius>() as CelsiusString;
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
