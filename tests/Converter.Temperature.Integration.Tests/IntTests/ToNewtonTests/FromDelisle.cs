using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0, 33)]
    [InlineData(150, 0)]
    public void Test_int_extension_from_delisle_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromDelisle().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
