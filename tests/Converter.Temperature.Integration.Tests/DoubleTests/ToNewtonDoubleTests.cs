using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests;

public sealed class ToNewtonDoubleTests
{
    [Theory]
    [InlineData(100.0, 33.0)]
    [InlineData(0.0, 0.0)]
    [InlineData(-33.0, -10.89)]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromCelsius().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(212.0, 33.0)]
    [InlineData(32.0, 0.0)]
    public void Test_ToNewton_FromFahrenheit_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromFahrenheit().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(373.15, 33.0)]
    [InlineData(273.15, 0.0)]
    public void Test_ToNewton_FromKelvin_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromKelvin().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(671.67, 33.0)]
    [InlineData(491.67, 0.0)]
    public void Test_ToNewton_FromRankine_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromRankine().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(60.0, 33.0)]
    [InlineData(7.5, 0.0)]
    public void Test_ToNewton_FromRømer_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromRømer().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(0.0, 33.0)]
    [InlineData(150.0, 0.0)]
    public void Test_ToNewton_FromDelisle_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromDelisle().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }

    [Theory]
    [InlineData(33.0, 33.0)]
    [InlineData(0.0, 0.0)]
    public void Test_ToNewton_FromNewton_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromNewton().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(80.0, 33.0)]
    [InlineData(0.0, 0.0)]
    public void Test_ToNewton_FromRéaumur_Returns_Correct_Value(double input, double expected)
    {
        // Act
        double result = input.FromRéaumur().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01);
    }
}
