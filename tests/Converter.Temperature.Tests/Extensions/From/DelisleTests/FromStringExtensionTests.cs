using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, DelisleString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString("R"),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString("R")) { }

    protected override DelisleString ConvertFrom(
        string value)
    {
        return value.FromDelisle();
    }

    [Fact]
    public void Test_from_delisle_returns_delisle_string_type()
    {
        // Arrange.
        const string input = "39.9";

        // Act.
        DelisleString result = input.FromDelisle();

        // Assert.
        result.Should()
            .BeOfType<DelisleString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
