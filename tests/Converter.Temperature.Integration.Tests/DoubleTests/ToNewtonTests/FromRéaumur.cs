using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToNewtonTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(80.0, 33.0)]
    [InlineData(0.0, 0.0)]
    public void Test_double_extension_from_réaumur_to_newton_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.01);
    }
}
