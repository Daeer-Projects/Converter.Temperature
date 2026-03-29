using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromKelvin
{
    [Theory]
    [InlineData(273, 0)]
    [InlineData(373, 80)]
    public void Test_int_extension_from_kelvin_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromKelvin().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
