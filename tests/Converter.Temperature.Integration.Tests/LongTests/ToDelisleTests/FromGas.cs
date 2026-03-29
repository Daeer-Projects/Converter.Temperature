using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromGas
{
    [Theory]
    [InlineData(1L, -75L)]
    [InlineData(6L, -176L)]
    public void Test_long_extension_from_gas_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
