using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToDelisleTests;

public class FromGas
{
    [Theory]
    [InlineData(1d, -60d)]
    [InlineData(6d, -150d)]
    public void Test_double_extension_from_gas_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
