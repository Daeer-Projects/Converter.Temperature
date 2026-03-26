using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Newton;

public sealed class ToDoubleExtensionTests
{
    [Fact]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value()
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
