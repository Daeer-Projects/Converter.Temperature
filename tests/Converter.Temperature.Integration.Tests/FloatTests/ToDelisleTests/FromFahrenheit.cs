using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(32f, 150f)]
    [InlineData(212f, 0f)]
    public void Test_float_extension_from_fahrenheit_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
