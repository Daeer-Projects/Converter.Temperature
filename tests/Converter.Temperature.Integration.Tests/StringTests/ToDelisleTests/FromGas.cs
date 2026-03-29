using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToDelisleTests;

public class FromGas
{
    [Theory]
    [InlineData("1", "-60")]
    [InlineData("6", "-150")]
    public void Test_string_extension_from_gas_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
