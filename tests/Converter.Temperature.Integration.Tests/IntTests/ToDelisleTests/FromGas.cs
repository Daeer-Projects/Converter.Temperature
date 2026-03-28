using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromGas
{
    [Theory]
    [InlineData(1, -75)]
    [InlineData(6, -176)]
    [InlineData(10, -248)]
    public void Test_int_extension_from_gas_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
