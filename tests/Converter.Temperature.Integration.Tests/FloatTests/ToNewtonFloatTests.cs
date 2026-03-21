using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests;

public sealed class ToNewtonFloatTests
{
    [Theory]
    [InlineData(100.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromCelsius().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(212.0f, 33.0f)]
    [InlineData(32.0f, 0.0f)]
    public void Test_ToNewton_FromFahrenheit_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromFahrenheit().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(373.15f, 33.0f)]
    [InlineData(273.15f, 0.0f)]
    public void Test_ToNewton_FromKelvin_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromKelvin().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(671.67f, 33.0f)]
    [InlineData(491.67f, 0.0f)]
    public void Test_ToNewton_FromRankine_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromRankine().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(60.0f, 33.0f)]
    [InlineData(7.5f, 0.0f)]
    public void Test_ToNewton_FromRømer_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromRømer().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(0.0f, 33.0f)]
    [InlineData(150.0f, 0.0f)]
    public void Test_ToNewton_FromDelisle_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromDelisle().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(33.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_ToNewton_FromNewton_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromNewton().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(80.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_ToNewton_FromRéaumur_Returns_Correct_Value(float input, float expected)
    {
        // Act
        float result = input.FromRéaumur().ToNewton();

        // Assert
        result.Should().BeApproximately(expected, 0.01f);
    }
}
