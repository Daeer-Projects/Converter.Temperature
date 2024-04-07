namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using System.Globalization;
using FluentAssertions;
using Temperature.Extensions.From;
using Types.Gas;
using Xunit;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, GasString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override GasString ConvertFrom(
        string value)
    {
        return value.FromGas();
    }

    [Fact]
    public void Test_from_gas_returns_gas_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        GasString result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
