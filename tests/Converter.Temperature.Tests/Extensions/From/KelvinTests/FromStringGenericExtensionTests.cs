namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using System.Globalization;
using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Kelvin;
using Xunit;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, KelvinString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override KelvinString ConvertFrom(
        string value)
    {
        return value.From<Kelvin>() as KelvinString;
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
