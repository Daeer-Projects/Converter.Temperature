using Converter.Temperature.Extensions.To.Réaumur;

namespace Converter.Temperature.Integration.Tests.DoubleTests;

using System.Collections.Generic;
using Extensions.From;
using Extensions.To;
using TemperatureTypes;
using FluentAssertions;
using Xunit;

public class ToRéaumurDoubleTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(100, 80)]
    public void Test_ToRéaumur_FromCelsius_Returns_Correct_Value(double input, double expected)
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
    public void Test_ToRéaumur_FromFahrenheit_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromFahrenheit().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(373.15, 80)]
    public void Test_ToRéaumur_FromKelvin_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromKelvin().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(491.67, 0)]
    [InlineData(671.67, 80)]
    public void Test_ToRéaumur_FromRankine_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromRankine().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 80)]
    [InlineData(150, 0)]
    public void Test_ToRéaumur_FromDelisle_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromDelisle().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    public void Test_ToRéaumur_FromNewton_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromNewton().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(7.5, 0)]
    [InlineData(60, 80)]
    public void Test_ToRéaumur_FromRømer_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromRømer().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(80, 80)]
    public void Test_ToRéaumur_FromRéaumur_Returns_Correct_Value(double input, double expected)
    {
        // Arrange
        // Act
        var result = input.FromRéaumur().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_ToRéaumur_Generic_Returns_Correct_Value()
    {
        // Arrange
        const double input = 100;
        const double expected = 80;

        // Act
        var result = input.FromCelsius().To<Réaumur>();

        // Assert
        result.Should().Be(expected);
    }
}
