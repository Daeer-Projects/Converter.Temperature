using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, DelisleString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override DelisleString ConvertFrom(
        string value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        DelisleString result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
