using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Newton;

public sealed class ToIntExtensionTests
{
    [Fact]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value()
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
