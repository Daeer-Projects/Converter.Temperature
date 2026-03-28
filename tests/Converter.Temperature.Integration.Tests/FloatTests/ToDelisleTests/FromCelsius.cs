using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromCelsius
{
    [Theory]
    [InlineData(0f, 150f)]
    [InlineData(100f, 0f)]
    [InlineData(-100f, 300f)]
    public void Test_float_extension_from_celsius_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
