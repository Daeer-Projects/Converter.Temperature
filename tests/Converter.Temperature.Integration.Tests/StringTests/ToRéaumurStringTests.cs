namespace Converter.Temperature.Integration.Tests.StringTests;

using Extensions.From;
using Extensions.To;
using TemperatureTypes;
using FluentAssertions;
using Xunit;

public class ToRéaumurStringTests
{
    [Theory]
    [InlineData("0", "0")]
    [InlineData("100", "80")]
    public void Test_ToRéaumur_FromCelsius_Returns_Correct_Value(string input, string expected)
    {
        // Arrange
        // Act
        var result = input.FromCelsius().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("32", "0")]
    [InlineData("212", "80")]
    public void Test_ToRéaumur_FromFahrenheit_Returns_Correct_Value(string input, string expected)
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
        const string input = "100";
        const string expected = "80";

        // Act
        var result = input.FromCelsius().To<Réaumur>();

        // Assert
        result.Should().Be(expected);
    }
}
