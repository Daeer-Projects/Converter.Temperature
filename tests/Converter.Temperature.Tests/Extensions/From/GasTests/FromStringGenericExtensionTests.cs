namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using System.Globalization;
using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Gas;
using Xunit;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, GasString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override GasString ConvertFrom(
        string value)
    {
        return value.From<Gas>() as GasString;
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
