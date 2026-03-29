using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromCelsius
{
    [Theory]
    [InlineData(100, 33)]
    [InlineData(0, 0)]
    [InlineData(-33, -11)]
    public void Test_int_extension_from_celsius_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
