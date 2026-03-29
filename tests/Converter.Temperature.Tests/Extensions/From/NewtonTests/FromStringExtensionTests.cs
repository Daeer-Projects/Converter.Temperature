using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, NewtonString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override NewtonString ConvertFrom(
        string value)
    {
        return value.FromNewton();
    }

    [Fact]
    public void Test_from_newton_returns_newton_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        NewtonString result = input.FromNewton();

        // Assert.
        result.Should()
            .BeOfType<NewtonString>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_newton_returns_correct_value()
    {
        // Arrange.
        const string input = "10";

        // Act.
        NewtonString result = input.FromNewton();

        // Assert.
        result.Temperature.Should().Be(input);
    }
}
