using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(64f, 0.25f)]
    [InlineData(160f, 6f)]
    [InlineData(196f, 10f)]
    public void Test_float_extensions_from_réaumur_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRéaumur()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(64f, 0.25f)]
    [InlineData(160f, 6f)]
    [InlineData(196f, 10f)]
    public void Test_float_extensions_generic_from_réaumur_to_gas_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Réaumur>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(63.2000007629395f, "Temp too low for gas mark!")]
    [InlineData(216f, "Temp too high for gas mark!")]
    public void Test_float_extensions_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }

    [Theory]
    [InlineData(63.2000007629395f, "Temp too low for gas mark!")]
    [InlineData(216f, "Temp too high for gas mark!")]
    public void Test_float_extensions_generic_from_réaumur_to_gas_with_invalid_parameters_throws_exception(
        float input,
        string expectedError)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain(expectedError);
    }
}
