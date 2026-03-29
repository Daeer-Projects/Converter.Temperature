using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromGas
{
    [Theory]
    [InlineData(1f, -60f)]
    [InlineData(6f, -150f)]
    public void Test_float_extension_from_gas_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromGas()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
