using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Newton;

public sealed class ToIntExtensionTests
{
    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int input = 100;
        const int expected = 33;

        // Act.
        int result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}

