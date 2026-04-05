using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToNewtonTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(80.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_float_extension_from_réaumur_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRéaumur().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(80.0f, 33.0f)]
    [InlineData(0.0f, 0.0f)]
    public void Test_float_extension_generic_from_réaumur_to_newton_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.

        // Act.
        float result = input.From<Réaumur>().To<Newton>();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_réaumur_to_newton_with_invalid_parameter_throws_exception(float input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToNewton());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_generic_from_réaumur_to_newton_with_invalid_parameter_throws_exception(
        float input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Newton>());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }
}
