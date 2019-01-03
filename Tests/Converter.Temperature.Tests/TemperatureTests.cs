using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests
{
    public class TemperatureTests
    {
        [Fact]
        public void Test_celsius_to_celsius_with_valid_double_returns_same_value()
        {
            // Arrange.
            const double expected = 39d;

            // Act.
            var actual = Temperature.CelsiusToCelsius(expected);

            // Assert.
            actual.Should().Be(expected, "the values are the same.");
        }
    }
}