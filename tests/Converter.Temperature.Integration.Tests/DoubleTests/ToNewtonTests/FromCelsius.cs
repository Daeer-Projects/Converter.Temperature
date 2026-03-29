using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToNewtonTests;

public class FromCelsius
{
    [Theory]
    [InlineData(100.0, 33.0)]
    [InlineData(0.0, 0.0)]
    [InlineData(-33.0, -10.89)]
    public void Test_double_extension_from_celsius_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }
}
