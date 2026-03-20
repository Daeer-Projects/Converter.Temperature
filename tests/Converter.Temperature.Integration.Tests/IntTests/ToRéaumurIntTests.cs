namespace Converter.Temperature.Integration.Tests.IntTests;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

public class ToRéaumurIntTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 80)]
    public void Test_ToRéaumur_FromCelsius_Returns_Correct_Value(int input, int expected)
    {
        // Arrange
        // Act
        var result = input.FromCelsius().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 80)]
    public void Test_ToRéaumur_FromFahrenheit_Returns_Correct_Value(int input, int expected)
    {
        // Arrange
        // Act
        var result = input.FromFahrenheit().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_ToRéaumur_Generic_Returns_Correct_Value()
    {
        // Arrange
        const int input = 100;
        const int expected = 80;

        // Act
        var result = input.FromCelsius().To<Réaumur>();

        // Assert
        result.Should().Be(expected);
    }
}
