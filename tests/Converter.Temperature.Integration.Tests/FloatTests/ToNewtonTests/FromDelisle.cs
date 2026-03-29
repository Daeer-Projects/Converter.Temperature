using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToNewtonTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0.0f, 33.0f)]
    [InlineData(150.0f, 0.0f)]
    public void Test_float_extension_from_delisle_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }
}
