using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Newton;

public sealed class ToDoubleExtensionTests
{
    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double input = 100.0;
        const double expected = 33.0;

        // Act.
        double result = input.FromCelsius().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
