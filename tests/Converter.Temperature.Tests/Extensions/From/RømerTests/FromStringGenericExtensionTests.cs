namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using System.Globalization;
using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rømer;
using Xunit;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, RømerString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override RømerString ConvertFrom(
        string value)
    {
        return value.From<Rømer>() as RømerString;
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
