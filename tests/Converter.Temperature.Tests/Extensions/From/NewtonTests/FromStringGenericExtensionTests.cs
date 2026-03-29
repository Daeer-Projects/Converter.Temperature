using System.Globalization;
using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public class FromStringGenericExtensionTests : BaseFromExtensionTests<string, NewtonString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override NewtonString ConvertFrom(
        string value)
    {
        return value.From<Newton>() as NewtonString;
    }

    [Fact]
    public void Test_from_newton_generic_returns_newton_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Newton>();

        // Assert.
        result.Should()
            .BeOfType<NewtonString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
