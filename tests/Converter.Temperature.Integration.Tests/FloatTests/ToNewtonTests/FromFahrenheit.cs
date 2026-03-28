using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToNewtonTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(212.0f, 33.0f)]
    [InlineData(32.0f, 0.0f)]
    public void Test_float_extension_from_fahrenheit_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromFahrenheit().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }
}
