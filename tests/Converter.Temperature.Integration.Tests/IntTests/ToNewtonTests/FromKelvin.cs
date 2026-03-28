using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToNewtonTests;

public class FromKelvin
{
    [Theory]
    [InlineData(373, 33)]
    [InlineData(273, 0)]
    public void Test_int_extension_from_kelvin_to_newton_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
